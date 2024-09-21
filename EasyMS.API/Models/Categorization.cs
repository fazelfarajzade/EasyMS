namespace EasyMS.API.Models
{
    public class Categorization
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategorizedType { get; set; } = string.Empty;
        public int CategorizedId { get; set; }
    }
}
