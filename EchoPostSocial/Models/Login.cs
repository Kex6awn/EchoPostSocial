using System.ComponentModel.DataAnnotations;

namespace EchoPostSocial.Models
{
    public class Login
    {
        // The userId is the primary key
        public int userId { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters")]
        public string userName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password")]
        [StringLength(100, ErrorMessage = "Password cannot be longer than 100 characters")]
        public string password { get; set; } = string.Empty;

        // First Name Column
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string firstName { get; set; } = string.Empty;

        // Last Name Column
        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
        public string lastName { get; set; } = string.Empty;
    }
}
