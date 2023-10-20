using Microsoft.AspNetCore.Mvc;
using WebApplicationPark.Models;

namespace WebApplicationPark.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Employees model)
        {
            if (ModelState.IsValid)
            {
                // Ваш код для регистрации нового пользователя
                // Создайте новую запись в базе данных для нового пользователя

                // После успешной регистрации, перенаправьте пользователя на главную страницу или на страницу входа
                return RedirectToAction("Index"); // Пример перенаправления на главную страницу
            }

            // Если модель недействительна, верните пользователя на страницу регистрации с ошибками
            return View(model);
        }
    }
}
