namespace BikeStores.Models.Customers
{
    public class TestDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public byte OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
