using Microsoft.AspNetCore.Mvc;
using WebApplicationPark.Models;

namespace WebApplicationPark.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(User user)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
