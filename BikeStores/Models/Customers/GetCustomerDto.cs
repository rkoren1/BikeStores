using BikeStores.Data;

namespace BikeStores.Models.Customers
{
    public class GetCustomerDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Phone { get; set; }
        public string Email { get; set; } = null!;

        public List<Product> Products { get; set; }
    }
}
