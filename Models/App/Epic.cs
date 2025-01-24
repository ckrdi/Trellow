namespace Trellow.Models.App
{
    public class Epic : Base.Model
    {
        public string? Code { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Color { get; set; }

        public string? Status { get; set; }

        public string? IssueType { get; set; }

        public int ReporterId { get; set; }

        public int? AssigneeId { get; set; }

        public bool IsDummy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}
