namespace BlogProject.Models
{
    public class Article
    {
        public int? ArticleId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public DateTime? PublishDate { get; set; }

    }
}
