using Microsoft.AspNetCore.Mvc;

namespace AbacusWebAPI.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
