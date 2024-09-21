namespace EasyMS.API.Models
{
    public class Revision
    {
        public int Id { get; set; }
        public string RecordType { get; set; } = string.Empty;
        public int RecordId { get; set; }
        public string? Data { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
