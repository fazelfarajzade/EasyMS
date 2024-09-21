namespace EasyMS.API.Models
{
    public class Translation
    {
        public int Id { get; set; }
        public string Local { get; set; } = string.Empty;
        public int PageId { get; set; }
        public int? LayoutId { get; set; }
        public string Label { get; set; } = string.Empty;
        public string ContentCache { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
