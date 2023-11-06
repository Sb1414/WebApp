using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplicationPark.Models;

public class Positions
{
    [Key]
    public int id { get; set; }
    
    [Display(Name = "Позиция")]
    [BindNever]
    public string Position { get; set; }
    
    [Display(Name = "Зарплата")]
    public string Salary { get; set; }
}