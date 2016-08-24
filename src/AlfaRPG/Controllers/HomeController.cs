using Microsoft.AspNetCore.Mvc;

namespace AlfaRPG.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
