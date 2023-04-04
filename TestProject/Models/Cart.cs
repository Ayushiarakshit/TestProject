namespace TestProject.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public List<Product> products { get; set; }
        public int UserId { get; set; }

        public int quantity { get; set; }
    }
}
