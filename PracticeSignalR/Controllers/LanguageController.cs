using Microsoft.AspNetCore.Mvc;

namespace PracticeSignalR.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
