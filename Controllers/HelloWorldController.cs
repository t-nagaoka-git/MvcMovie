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
        public string Welcome(string name, int Id = 1)
        {
            return $"名前：{name}さん, ID：{Id}";
        }
    }
}
