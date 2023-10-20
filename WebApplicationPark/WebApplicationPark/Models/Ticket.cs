namespace WebApplicationPark.Models;

public class Ticket
{
    public int id { get; set; }
    private string purchaseDate;
    private int attractionID;

    public string PurchaseDate
    {
        get { return purchaseDate; }
        set { purchaseDate = value; }
    }

    public int AttractionID
    {
        get { return attractionID; }
        set { attractionID = value; }
    }

    public Ticket() { }
    public Ticket(string purchaseDate, int attractionID)
    {
        this.purchaseDate = purchaseDate;
        this.attractionID = attractionID;
    }
}