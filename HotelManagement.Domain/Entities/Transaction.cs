using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Domain
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Required]
        [MaxLength(50)]
        public string TransactionName { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employees Employees { get; set; }
        //public int ReservationId { get; set; }
        //public Reservation Reservation { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
    }
}
