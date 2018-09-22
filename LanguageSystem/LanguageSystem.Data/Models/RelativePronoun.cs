﻿using System.ComponentModel.DataAnnotations;

namespace LanguageSystem.Data.Models
{
    public class RelativePronoun
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        public string Content { get; set; }
    }
}