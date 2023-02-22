using System.ComponentModel.DataAnnotations;

namespace APIJWTAuthenticationProject
{
    public class UserCredential
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "UserName Can't be Blank")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password Can't be Blank")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Role Can't be Blank")]
        public string? Role { get; set; }
    }
}
