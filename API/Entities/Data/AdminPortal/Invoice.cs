namespace API.Entities.Data.AdminPortal
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal Price { get; set; }
    }
}
