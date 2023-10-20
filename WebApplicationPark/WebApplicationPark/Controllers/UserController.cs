using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationPark.Models;

namespace WebApplicationPark.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.Users.FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password);

                if (existingUser != null)
                {
                    // Пользователь существует, выполните необходимые действия
                    return Redirect("/");
                }
                else
                {
                    // Пользователь не существует, верните на страницу входа
                    ModelState.AddModelError("login", "Пользователь с таким логином и паролем не найден.");
                    return View("Index");
                }
            }
            return View("Index");
        }

    }
}
