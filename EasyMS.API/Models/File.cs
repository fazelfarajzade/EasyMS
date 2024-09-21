namespace EasyMS.API.Models
{
    public class File
    {
        public int Id { get; set; }
        public required int SiteId { get; set; }
        public required string Label { get; set; }
        public string? Description { get; set; }
        public required string FilePath { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
