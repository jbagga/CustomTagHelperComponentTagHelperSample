using Microsoft.AspNetCore.Mvc;

namespace CustomTagHelperComponentTagHelperSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
