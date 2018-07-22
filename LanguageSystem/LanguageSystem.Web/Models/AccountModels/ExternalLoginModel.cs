using System.ComponentModel.DataAnnotations;

namespace LanguageSystem.Web.Models.AccountModels
{
    public class ExternalLoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}