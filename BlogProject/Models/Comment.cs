namespace BlogProject.Models
{
    public class Comment
    {
        public int? CommentId { get; set; }
        public string? CommentText { get; set; }= string.Empty;
        public string? CommenterName { get; set; }
        public string? CommenterSurname { get; set; }
        public int EssayID { get; set; }
        public DateTime? CommentDate { get; set; }
    }
}
