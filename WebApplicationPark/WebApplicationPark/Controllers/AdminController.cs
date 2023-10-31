using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        ViewBag.Positions = new SelectList(_context.Positions, "Position", "Position");
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
        
        var positionName = model.Position.Position;
        var position = _context.Positions.FirstOrDefault(p => p.Position == positionName);
        var positionId = position.id;
        

        if (existingEmployee == null)
        {
            return NotFound(); // Обработка случая, если сотрудник не найден
        }

        // Примените изменения к существующему сотруднику
        existingEmployee.FirstName = model.FirstName;
        existingEmployee.LastName = model.LastName;
        existingEmployee.DateOfBirth = model.DateOfBirth;
        existingEmployee.PositionID = positionId;

        _context.SaveChanges(); // Сохраните изменения в базе данных

        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult DeleteEmployee(int id)
    {
        var employeeToDelete = _context.Employees.FirstOrDefault(e => e.Id == id);

        Console.WriteLine("\n\n\n\nDeleteEmployee\n\n\n\n");
        
        if (employeeToDelete == null)
        {
            Console.WriteLine("\n\n\n\nОбработка случая, если сотрудник не найден\n\n\n\n");
            return NotFound(); // Обработка случая, если сотрудник не найден
        }

        _context.Employees.Remove(employeeToDelete);
        _context.SaveChanges(); // Удаление сотрудника из базы данных

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