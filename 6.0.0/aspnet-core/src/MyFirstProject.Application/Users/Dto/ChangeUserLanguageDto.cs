using System.ComponentModel.DataAnnotations;

namespace MyFirstProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}