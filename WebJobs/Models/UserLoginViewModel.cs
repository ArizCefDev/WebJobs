using System.ComponentModel.DataAnnotations;

namespace WebJobs.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }
    }
}
