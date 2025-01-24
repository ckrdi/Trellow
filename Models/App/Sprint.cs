namespace Trellow.Models.App
{
    public class Sprint : Base.Model
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Status { get; set; }

        public bool IsDummy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}
