using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Logging;
using WebMVCAppDI.Services;

namespace WebMVCAppDI.Controllers
{
    public class GreetController : Controller
    {
        // IGreetService service = new GreetService2();

        private IGreetService _service { get; set; }

        public GreetController(IGreetService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            ViewBag.greet = _service.SayHello();
            return View();
        }
    }
}
