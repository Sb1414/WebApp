namespace WebApplicationPark.Models
{
    public class TicketSales
    {
        public int id { get; set; }
        public int TicketId { get; set; }
        public int EmployeeId { get; set; }
        private string SaleTime { get; set; }
    }
}
