using Microsoft.AspNetCore.Mvc;
using WebApplicationPark.Models;

namespace WebApplicationPark.Controllers;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IActionResult EditEmployee(int id)
    {
        var employee = _context.Employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return NotFound(); // Обработка случая, если сотрудник не найден
        }

        // Здесь вы можете передать сотрудника на представление для редактирования
        return View(employee);
    }

    [HttpPost]
    public IActionResult SaveEmployee(Employees model)
    {
        //if (!ModelState.IsValid)
        //{
            // В случае неверных данных, вернуть представление редактирования
        //    return View("EditEmployee", model);
        //}
        Console.WriteLine("\n\n\n\nya tyt\n\n\n\n");
        var existingEmployee = _context.Employees.FirstOrDefault(e => e.Id == model.Id);

        if (existingEmployee == null)
        {
            return NotFound(); // Обработка случая, если сотрудник не найден
        }

        // Примените изменения к существующему сотруднику
        existingEmployee.FirstName = model.FirstName;
        existingEmployee.LastName = model.LastName;
        existingEmployee.DateOfBirth = model.DateOfBirth;
        existingEmployee.PositionID = model.PositionID;

        _context.SaveChanges(); // Сохраните изменения в базе данных

        return RedirectToAction("Index");
    }


    public IActionResult Index()
    {
        //var employees = _context.Employees
       //     .Join(_context.Positions, e => e.PositionID, p => p.id, (e, p) => new { Employee = e, Position = p })
        //    .Select(x => new { FirstName = x.Employee.FirstName, LastName = x.Employee.LastName, DateOfBirth = x.Employee.DateOfBirth, Position = x.Position.Position })
         //   .ToList();
        
         var employees = _context.Employees
            .Join(_context.Positions, e => e.PositionID, p => p.id, (e, p) => new { Id = e.Id, FirstName = e.FirstName, LastName = e.LastName, DateOfBirth = e.DateOfBirth, Position = p.Position })
            .ToList();

        return View(employees);
    }

}