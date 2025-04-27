using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserLogin
    {
        public int UserLoginId {get; set;}
        [Required(ErrorMessage ="You must Enter an Email !")]
        public string Email { get; set;}

        [Required(ErrorMessage = "You must Enter a Password !")]
        public string Password { get; set;}
    }
}
