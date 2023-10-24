namespace WebApplicationPark.Models;

public class Positions
{
    public int id { get; set; }
    private string position, salary;


    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public string Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public Positions() { }
    public Positions(string salary, string position)
    {
        this.position = position;
        this.salary = salary;
    }
}