using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        [Required]
        public DateTime DateIn { get; set; }
        [Required]
        public DateTime DateOut { get; set; }
        [Required]
        public int DaysRange { get; set; }
    }
}
