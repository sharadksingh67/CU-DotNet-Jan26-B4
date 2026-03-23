using Microsoft.AspNetCore.Mvc;
using WebMVCAppDI.Services;

namespace WebMVCAppDI.Controllers
{
    public class TestController : Controller
    {
        // IGreetService service = new GreetService2();
        private IGreetService _service { get; set; }
        public TestController(IGreetService service)
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
