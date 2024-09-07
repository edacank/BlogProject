using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
