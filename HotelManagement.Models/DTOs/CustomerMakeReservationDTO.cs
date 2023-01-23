namespace HotelManagement.Models.DTOs
{
    public class CustomerMakeReservationDTO
    {
        public string CustomerName { get; set; } = null!;
        public string CustomerLastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public CreateReservationDTO Reservation { get; set; }
        public CreatePaymentDTO Payment { get; set; }

    }
}
