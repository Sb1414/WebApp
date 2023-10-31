using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models;

public class Positions
{
    [Key]
    public int id { get; set; }
    
    [Display(Name = "Позиция")]
    public string Position { get; set; }
    
    [Display(Name = "Зарплата")]
    public string Salary { get; set; }
}