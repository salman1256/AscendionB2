using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
