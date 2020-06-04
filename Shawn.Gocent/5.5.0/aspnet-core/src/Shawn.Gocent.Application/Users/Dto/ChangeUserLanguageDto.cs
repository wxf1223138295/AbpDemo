using System.ComponentModel.DataAnnotations;

namespace Shawn.Gocent.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}