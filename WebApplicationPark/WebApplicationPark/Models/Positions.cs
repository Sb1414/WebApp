using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models;

public class Positions
{
    [Key]
    public int id { get; set; }
    
    [Required(ErrorMessage = "Введите позицию")]
    [Display(Name = "Позиция")]
    public string Position { get; set; }
    
    [Required(ErrorMessage = "Введите зарплату")]
    [Display(Name = "Зарплата")]
    public string Salary { get; set; }
}