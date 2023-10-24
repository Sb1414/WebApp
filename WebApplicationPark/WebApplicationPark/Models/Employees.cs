using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models;

public class Employees
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage ="введите логин")]
    [Display(Name = "введите логин")]
    [StringLength(100, MinimumLength = 3)]
    public string Login { get; set; }

    [Required(ErrorMessage = "введите пароль")]
    [Display(Name = "введите пароль")]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; }

    [Required(ErrorMessage = "введите имя")]
    [Display(Name = "введите имя")]
    [StringLength(100)]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "введите фамилию")]
    [Display(Name = "введите фамилию")]
    [StringLength(100)]
    public string LastName { get; set; }

    [Required(ErrorMessage = "введите дату рождения")]
    [Display(Name = "введите дату рождения")]
    public string DateOfBirth { get; set; }

    public int PositionID { get; set; }

}