using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models;

public class Employees
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите логин")]
    [Display(Name = "Логин")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Логин должен содержать не менее 3 символов.")]
    [Remote(action: "VerifyLogin", controller: "Registration", ErrorMessage = "Пользователь с таким логином уже существует.")]
    public string Login { get; set; }

    [Required(ErrorMessage = "Введите пароль")]
    [Display(Name = "Пароль")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Пароль должен содержать не менее 8 символов.")]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]+$", ErrorMessage = "Пароль должен содержать буквы и цифры без пробелов.")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Введите имя")]
    [Display(Name = "Имя")]
    [RegularExpression(@"^[A-ZА-Я][a-zа-я]*$", ErrorMessage = "Имя должно начинаться с заглавной буквы и содержать только буквы.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Введите фамилию")]
    [Display(Name = "Фамилия")]
    [RegularExpression(@"^[A-ZА-Я][a-zа-я]*$", ErrorMessage = "Фамилия должна начинаться с заглавной буквы и содержать только буквы.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Введите дату рождения")]
    [Display(Name = "Дата рождения")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    public int PositionID { get; set; }

}