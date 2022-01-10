using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace AspNetCoreMVCClient.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private ServiceClient client = new ServiceClient();

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.result1 = client.GetHelloWorldAsync().Result;
            ViewBag.result2 = client.GetNameAsync("Pusheen").Result;
            ViewBag.result3 = client.CountAsync(1, 2).Result;
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
