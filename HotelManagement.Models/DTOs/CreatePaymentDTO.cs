namespace HotelManagement.Models.DTOs
{
    public class CreatePaymentDTO
    {
        public int CustomerId { get; set; }
        public string PaymentType { get; set; } = null!;
        public DateTime PaymentDate { get; set; }
    }
}
