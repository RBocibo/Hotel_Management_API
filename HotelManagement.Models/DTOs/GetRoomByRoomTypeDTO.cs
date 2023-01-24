namespace HotelManagement.Models.DTOs
{
    public class GetRoomByRoomTypeDTO
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; } = null!;
        public string RoomSample { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
