using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Traveler
    {

        public int TravelerId { get; set; }

        [Required (ErrorMessage = "You must enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter your Age")]
        [Range(18,60,ErrorMessage ="Your Age must be between 18 and 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "You must enter your email")]
        public string Email { get; set; }
        
        [Required]
        public int Seats { get; set; }

        public string TripId { get; set; }

        [ValidateNever]
        public Trip Trips { get; set; }

    }
}
