using System.ComponentModel.DataAnnotations;

namespace EasyMS.API.ApiModels.Aauthentication
{
    public class RefreshModel
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}
