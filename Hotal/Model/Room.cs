namespace Hotal.Model
{
    public class Room
    {
       // internal readonly object Availability;

        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }

        public Hotel Hotel { get; set; }
        public List<Reservation> Reservations { get; set; }
        public bool Availability { get; set; }
    }
}
