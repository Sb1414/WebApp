using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models
{
    public class Login
    {
        [Key]
        private int id { get; set; }
        [Display(Name = "Введите логин")]
        [Required(ErrorMessage ="Нужно ввести логин")]
        public string login { get; set; }

        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Нужно ввести пароль")]
        public string password { get; set; }
    }
}
