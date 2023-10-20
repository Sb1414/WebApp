using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Введите логин")]
        [Required(ErrorMessage ="Нужно ввести логин")]
        public string Login { get; set; }

        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Нужно ввести пароль")]
        public string Password { get; set; }
    }
}
