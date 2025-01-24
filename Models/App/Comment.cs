namespace Trellow.Models.App
{
    public class Comment : Base.Model
    {
        public int CommenterId { get; set; }

        public string? Text { get; set; }

        public int? EpicId { get; set; }

        public int? CardId { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
