using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string CustomerLastName { get; set; } = null!;
        [Required]
        [MaxLength(500)]
        public string Address { get; set; } = null!;
        [Required]
        public string Status { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = null!;
        public ICollection<Payment> Payments { get; set; }
        public Reservation Reservation { get; set; }


    }
}
