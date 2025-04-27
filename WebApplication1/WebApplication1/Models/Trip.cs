using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Trip
    {
       
        public string TripId { get; set; }
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Price { get; set; }

        public int Remaining_Seats { get; set;}



    }
}
