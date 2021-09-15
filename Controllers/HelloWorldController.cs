using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // HelloWorld にアクセスしたときの処理
        public IActionResult Index()
        {
            return View();
        }

        // HelloWorld/Welcome にアクセスしたときの処理
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"こんにちは！{name}さん";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
