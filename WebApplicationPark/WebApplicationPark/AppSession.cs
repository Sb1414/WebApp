namespace WebApplicationPark;

public class AppSession
{
    public static bool IsLoggedIn { get; set; } // Общая переменная для проверки входа
    public static string UserLogin { get; set; } // логин залогиненного юзера
}