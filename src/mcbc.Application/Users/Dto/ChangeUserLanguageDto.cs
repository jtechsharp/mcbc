using System.ComponentModel.DataAnnotations;

namespace mcbc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}