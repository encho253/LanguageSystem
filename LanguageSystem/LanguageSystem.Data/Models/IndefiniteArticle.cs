using System.ComponentModel.DataAnnotations;

namespace LanguageSystem.Data.Models
{
    public class IndefiniteArticle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(1)]
        public string Content { get; set; }
    }
}