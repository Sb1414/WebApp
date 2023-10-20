namespace WebApplicationPark.Models;

public class Employees
{
    public int id { get; set; }
    private string firstName, lastName, dateOfBirth, position;
    private int salary;

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

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Employees() { }
    public Employees(string firstName, string lastName, string dateOfBirth, string position, int salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.dateOfBirth = dateOfBirth;
        this.position = position;
        this.salary = salary;
    }
}