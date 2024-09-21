namespace EasyMS.API.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public required string Key { get; set; }
        public required string Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
