using Microsoft.AspNetCore.Mvc;

namespace ByteTech.API.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
