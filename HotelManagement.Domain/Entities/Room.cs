using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        [MaxLength(50)]
        public string RoomType { get; set; } = null!;
        [Required]
        [MaxLength(500)]
        public string RoomSample { get; set; } = null!;
        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;
        public ICollection<Reservation> Reservations { get; set; }

    }
}
