using Dapper.Contrib.Extensions;

namespace EasyMS.API.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
