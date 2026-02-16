using System.ComponentModel.DataAnnotations;

namespace Apple_Music_Dashboard.Models.Enitities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }

}
