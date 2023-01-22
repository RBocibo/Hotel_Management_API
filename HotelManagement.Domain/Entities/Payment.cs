using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public string PaymentType { get; set; } = null!;
        [Required]
        public DateTime PaymentDate { get; set; }

    }
}
