using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LanguageSystem.Data.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public List<QuestionAnswer> QuestionAnswers { get; set; } = new List<QuestionAnswer>();
    }
}