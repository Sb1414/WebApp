namespace WebApplicationPark.Models;

public class Shift
{
    public int id { get; set; }
    private string startTime, endTime;
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

    public int EmployeeID
    {
        get { return employeeID; }
        set { employeeID = value; }
    }

    public Shift() { }
    public Shift(string startTime, string endTime, int employeeID)
    {
        this.startTime = startTime;
        this.endTime = endTime;
        this.employeeID = employeeID;
    }
}