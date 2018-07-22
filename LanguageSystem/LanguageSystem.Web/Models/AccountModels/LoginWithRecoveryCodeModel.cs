using System.ComponentModel.DataAnnotations;

namespace LanguageSystem.Web.Models.AccountModels
{
    public class LoginWithRecoveryCodeModel
    {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Recovery Code")]
            public string RecoveryCode { get; set; }
    }
}