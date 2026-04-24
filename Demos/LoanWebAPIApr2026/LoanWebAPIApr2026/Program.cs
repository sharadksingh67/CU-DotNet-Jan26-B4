using FluentValidation;
using FluentValidation.AspNetCore;
using LoanWebAPIApr2026.Data;
using LoanWebAPIApr2026.Middleware;
using LoanWebAPIApr2026.Repositories;
using LoanWebAPIApr2026.Services;
using LoanWebAPIApr2026.Validators;
using Microsoft.EntityFrameworkCore;

using Serilog;

namespace LoanWebAPIApr2026
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<ILoanRepository, LoanRepository>();
            builder.Services.AddScoped<ILoanService, LoanService>();

            builder.Services.AddAutoMapper(cfg =>
            {
                cfg.AddMaps(typeof(Program).Assembly);
            });

            builder.Services.AddValidatorsFromAssemblyContaining<LoanRequestValidator>();
            builder.Services.AddFluentValidationAutoValidation();

            Log.Logger = new LoggerConfiguration()
                        .WriteTo.Console()
                        .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                        .CreateLogger();

            builder.Host.UseSerilog();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
