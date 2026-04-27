using LoanWebAPIApr2026.Common;
using LoanWebAPIApr2026.Exceptions;
using Serilog;

namespace LoanWebAPIApr2026.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private async Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            var response = new ApiResponse<string>
            {
                Success = false
            };

            switch (ex)
            {
                case BusinessException:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    response.Message = ex.Message;
                    break;

                case KeyNotFoundException:
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                    response.Message = ex.Message;
                    break;

                case FluentValidation.ValidationException validationEx:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    response.Message = string.Join(", ", validationEx.Errors.Select(e => e.ErrorMessage));
                    break;

                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    response.Message = "Internal Server Error" + ex.ToString();
                    Log.Error(ex, "Unhandled exception occurred");
                    break;
            }

            await context.Response.WriteAsJsonAsync(response);
        }
    }
}
