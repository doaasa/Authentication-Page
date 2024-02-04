using Microsoft.AspNetCore.Mvc;

namespace Authentication_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
