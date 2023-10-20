namespace WebApplicationPark.Models;

public class Attraction
{
    public int id { get; set; }
    private string name, description;
    private int capacity, ticketPrice;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public int TicketPrice
    {
        get { return ticketPrice; }
        set { ticketPrice = value; }
    }

    public Attraction() { }
    public Attraction(string name, string description, int capacity, int ticketPrice)
    {
        this.name = name;
        this.description = description;
        this.capacity = capacity;
        this.ticketPrice = ticketPrice;
    }
}