namespace EasyMS.API.Models
{
    public class Layout
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int ParentId { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Identifier { get; set; } = string.Empty;
        public string? Content { get; set; }
        public string? CSS { get; set; }
        public string? JS { get; set; }
        public int Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
