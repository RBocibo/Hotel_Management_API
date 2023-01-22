using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain
{
    public class RoomClass
    {
        [Key]
        public int RoomClassId { get; set; }
        [Required]
        [MaxLength(50)]
        public string RoomName { get; set; } = null!;
        [Required]
        public decimal RoomPrice { get; set; }
        public Room Room { get; set; }
    }
}
