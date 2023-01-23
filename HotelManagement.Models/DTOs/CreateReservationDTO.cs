namespace HotelManagement.Models.DTOs
{
    public class CreateReservationDTO
    {
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int DaysRange { get; set; }
    }
}
