namespace EasyMS.API.Models
{
    public class Snippet
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Identifier { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
