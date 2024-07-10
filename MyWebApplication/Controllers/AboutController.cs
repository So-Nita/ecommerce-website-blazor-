using Microsoft.AspNetCore.Mvc;

namespace MyWebApplication.Controllers
{
    public class AboutController : Controller
    {
        // AboutMe is class of view
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}
