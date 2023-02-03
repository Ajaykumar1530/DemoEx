using Microsoft.AspNetCore.Mvc;

namespace DemoEx.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
