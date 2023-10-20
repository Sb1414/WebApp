using Microsoft.AspNetCore.Mvc;
using WebApplicationPark.Models;

namespace WebApplicationPark.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check1(Employees model)
        {
            if (ModelState.IsValid)
            {
                // Проверка, существует ли пользователь с таким же логином
                var existingUser = _context.Employees.FirstOrDefault(u => u.Login == model.Login);

                if (existingUser != null)
                {
                    ModelState.AddModelError("login", "Пользователь с таким логином уже существует.");
                    return View(model);
                }

                // Создание нового пользователя
                var newUser = new Employees
                {
                    Login = model.Login,
                    Password = model.Password,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth
                };

                // Добавление пользователя в базу данных
                _context.Employees.Add(newUser);
                _context.SaveChanges();

                // Перенаправление на главную страницу или на страницу входа
                return RedirectToAction("Index", "Home"); // Пример перенаправления на главную страницу
            }

            // Если модель недействительна, верните пользователя на страницу регистрации с ошибками
            return View(model);
        }
    }
}
