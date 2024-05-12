using Microsoft.AspNetCore.Mvc;

namespace Asp.NetIntro_MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
