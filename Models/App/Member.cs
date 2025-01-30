namespace Trellow.Models.App
{
    public class Member : Base.Model
    {
        public string? Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
