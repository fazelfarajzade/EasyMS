namespace EasyMS.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Label { get; set; } = string.Empty;
        public string CategorizedType { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
