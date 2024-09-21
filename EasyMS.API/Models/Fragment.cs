namespace EasyMS.API.Models
{
    public class Fragment
    {
        public int Id { get; set; }
        public int RecordableId { get; set; }
        public string RecordableType { get; set; } = string.Empty;
        public string Identifier { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public bool Boolean { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
