using Microsoft.AspNetCore.Mvc;

namespace AbacusWebAPI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
