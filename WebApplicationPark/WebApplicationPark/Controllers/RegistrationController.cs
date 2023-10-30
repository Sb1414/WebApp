using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.Positions = new SelectList(_context.Positions, "Position", "Position");
            return View();
        }
        
        public IActionResult GetPositions()  
        {
            var positions = _context.Positions.ToList();
            return Json(positions);
        }

        public JsonResult VerifyLogin(string login)
        {
            var exists = _context.Employees.Any(x => x.Login == login);

            return Json(!exists);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Check1(Employees model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    // ViewData["FirstNameError"] = "Ошибка ввода имени";
                    return View("Index");
                    // return View(model); 
                }
                
                // Проверка, существует ли пользователь с таким же логином
                var existingUser = _context.Employees.FirstOrDefault(u => u.Login == model.Login);
                
                var positionName = model.Position.Position;
                var position = _context.Positions.FirstOrDefault(p => p.Position == positionName);
                var positionId = position.id;
                
                Console.WriteLine("\n\n =====  positionName ===== >>>>  : " + positionName + " <<< ===== positionName\n\n");
                Console.WriteLine("\n\n =====  position ===== >>>>  : " + position + " <<< ===== position\n\n");
                Console.WriteLine("\n\n =====  positionId ===== >>>>  : " + positionId + " <<< ===== positionId\n\n");

                if (existingUser != null)
                {
                    ViewBag.ErrorMessage = "Пользователь с таким логином уже существует.";

                    return View();
                }

                // Создание нового пользователя
                var newUser = new Employees
                {
                    Login = model.Login,
                    Password = model.Password,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth,
                    PositionID = positionId
                };
                
                // Добавление пользователя в базу данных
                _context.Employees.Add(newUser);
                _context.SaveChanges();

                // Перенаправление на главную страницу или на страницу входа
                return RedirectToAction("Index", "Home"); // Пример перенаправления на главную страницу
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View("Error", new ErrorViewModel { Message = ex.Message });
            }
        }
    }
}
