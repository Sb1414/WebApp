using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPark.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
