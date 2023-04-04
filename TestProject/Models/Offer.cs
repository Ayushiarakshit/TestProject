namespace TestProject.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string OfferDescription { get; set; }
        public string OfferName { get; set;}

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public bool IsActive { get; set; }
    }
}
