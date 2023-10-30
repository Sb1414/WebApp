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
        
        public IActionResult Logout()
        {
            AppSession.IsLoggedIn = false;
            AppSession.UserLogin = null;
            return RedirectToAction("Index", "Home"); // Перенаправьте пользователя на главную страницу или другую страницу после выхода
        }

        [HttpPost]
        public IActionResult Check(Employees user)
        {
            // if (!ModelState.IsValid)
            //    return View("Index");
            if (AppSession.IsLoggedIn == true)
            {
                AppSession.IsLoggedIn = false;
                AppSession.UserLogin = null;
            }
            ViewData["PasswordValue"] = user.Password; // Устанавливаем значение пароля, чтобы его сохранить

            var existingUser = _context.Employees.FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password);
            var passError = _context.Employees.FirstOrDefault(u => u.Login == user.Login && u.Password != user.Password);

            if (passError != null)  
            {
                //ModelState.AddModelError("Password", "Неверный пароль");
                //return View(user);
                ViewData["PasswordError"] = "Пароль неверный.";
                return View("Index");
            }

            else if (existingUser == null)
            {
                // ModelState.AddModelError("login", "Пользователь с таким логином и паролем не найден.");
                return RedirectToAction("Index", "Registration");
            }
            else
            {
                AppSession.IsLoggedIn = true;
                AppSession.UserLogin = user.Login;
                if (existingUser.Login == "admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
