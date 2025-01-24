namespace Trellow.Models.App
{
    public class Card : Base.Model
    {
        public int? EpicId { get; set; }

        public int? SprintId { get; set; }

        public int? ListId { get; set; }

        public string? IssueType { get; set; }

        public string? Code { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Priority { get; set; }

        public int ReporterId { get; set; }

        public int? AssigneeId { get; set; }

        public bool IsDummy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}
