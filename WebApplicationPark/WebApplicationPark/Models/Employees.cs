using System.ComponentModel.DataAnnotations;

namespace WebApplicationPark.Models;

public class Employees
{
    public int Id { get; set; }
    
    private string login, password, firstName, lastName, dateOfBirth;
    public string Password { 
        get { return password; }
        set { password = value; } 
    }
    public string Login
    {
        get { return login; }
        set { login = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public Employees() { }
    public Employees(string login, string password, string firstName, string lastName, string dateOfBirth)
    {
        this.login = login;
        this.password = password;
        this.firstName = firstName;
        this.lastName = lastName;
        this.dateOfBirth = dateOfBirth;
    }
}