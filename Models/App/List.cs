namespace Trellow.Models.App
{
    public class List : Base.Model
    {
        public int SprintId { get; set; }

        public Sprint? Sprint { get; set; }

        public string? Code { get; set; }

        public string? Title { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}
