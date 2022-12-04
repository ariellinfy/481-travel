using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class SignupModel
    {
        [Required(ErrorMessage = "Please enter a display name. e.g. happytraveler")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a valid email address. e.g. name@example.com")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address. e.g. name@example.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please re-enter your password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
