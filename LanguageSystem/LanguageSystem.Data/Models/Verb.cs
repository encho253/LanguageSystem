using System.ComponentModel.DataAnnotations;

namespace LanguageSystem.Data.Models
{
    public class Verb
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }
    }
}