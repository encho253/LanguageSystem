using System.ComponentModel.DataAnnotations;

namespace LanguageSystem.Web.Models.AccountModels
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}