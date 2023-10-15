using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models
{
    public class Login
    {
        [Display(Name = "Введите логин")]
        [Required(ErrorMessage ="Нужно ввести логин")]
        public string login { get; set; }

        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Нужно ввести пароль")]
        public string password { get; set; }
    }
}
