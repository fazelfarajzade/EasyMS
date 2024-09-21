using Dapper.Contrib.Extensions;

namespace EasyMS.API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int? RegUserId { get; set; }
        public required string Body { get; set; }
        public CommentStatuses Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public enum CommentStatuses
        {
            Pending = 1,
            Approved = 2,
            Rejected = 3
        }
    }
}
