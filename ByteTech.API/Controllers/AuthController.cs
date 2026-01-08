using Microsoft.AspNetCore.Mvc;

namespace ByteTech.API.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
