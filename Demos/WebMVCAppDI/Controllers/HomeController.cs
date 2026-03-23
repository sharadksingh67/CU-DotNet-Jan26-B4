using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVCAppDI.Models;
using WebMVCAppDI.Services;

namespace WebMVCAppDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGreetService _service { get; set; }
        public HomeController(ILogger<HomeController> logger,
            IGreetService service)
        {
            _logger = logger;
            _service = service;
        }

        // IGreetService service = new GreetService2();
        public IActionResult Index()
        {
            ViewBag.greet = _service.SayHello();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
