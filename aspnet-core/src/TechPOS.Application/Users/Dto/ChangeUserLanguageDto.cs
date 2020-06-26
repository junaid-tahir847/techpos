using System.ComponentModel.DataAnnotations;

namespace TechPOS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}