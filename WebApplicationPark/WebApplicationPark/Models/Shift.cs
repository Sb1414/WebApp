namespace WebApplicationPark.Models;

public class Shift
{
    public int id { get; set; }
    private string startTime, endTime, position, salary;
    private int employeeID;

    public string StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }

    public string EndTime
    {
        get { return endTime; }
        set { endTime = value; }
    }

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

    public int EmployeeID
    {
        get { return employeeID; }
        set { employeeID = value; }
    }

    public Shift() { }
    public Shift(string startTime, string endTime, string salary, string position, int employeeID)
    {
        this.startTime = startTime;
        this.endTime = endTime;
        this.position = position;
        this.salary = salary;
        this.employeeID = employeeID;
    }
}