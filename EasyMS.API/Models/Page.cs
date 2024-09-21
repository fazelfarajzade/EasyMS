namespace EasyMS.API.Models
{
    public class Page
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? LayoutId { get; set; }
        public int? ParentId { get; set; }
        public int? TargetPageId { get; set; }
        public string Label { get; set; } = string.Empty;
        public string? Slug { get; set; }
        public string FullPath { get; set; } = string.Empty;
        public string ContentCache { get; set; } = string.Empty;
        public  int Position { get; set; }
        public int ChildrenCount { get; set; }
        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
