using Microsoft.AspNetCore.Mvc;

namespace WebAppTwo.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
