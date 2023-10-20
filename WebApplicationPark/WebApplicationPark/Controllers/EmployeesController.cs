using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationPark.Models;

namespace WebApplicationPark.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Employees user)
        {
            if (!ModelState.IsValid)
                return View("Index");

            var existingUser = _context.Employees.FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password);

            if (existingUser != null && existingUser.Password != user.Password)
            {
                ModelState.AddModelError("password", "Неверный пароль");
                return View("Index");
            }

            else if (existingUser == null)
            {
                ModelState.AddModelError("login", "Пользователь с таким логином и паролем не найден.");
                return RedirectToAction("Register");
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
