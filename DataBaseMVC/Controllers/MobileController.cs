using Microsoft.AspNetCore.Mvc;

namespace DataBaseMVC.Controllers
{
    public class MobileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
