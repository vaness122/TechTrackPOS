using Microsoft.AspNetCore.Mvc;

namespace ByteTech.API.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
