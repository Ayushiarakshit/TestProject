namespace TestProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string UserReview { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}

        public int ProductId { get; set; }

    }
}
