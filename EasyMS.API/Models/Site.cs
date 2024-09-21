namespace EasyMS.API.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Identifier { get; set; } = string.Empty;
        public string HostName { get; set; } = string.Empty;
        public string? Path { get; set; }
        public string Locale { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
