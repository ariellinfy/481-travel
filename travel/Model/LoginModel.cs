using System.ComponentModel.DataAnnotations;

namespace travel.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please provide a valid email address. e.g. name@example.com")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address. e.g. name@example.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
