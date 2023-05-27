namespace Hotal.Model
{
    public class Availability
    {
        public bool AvailabilityId { get; set; }
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public bool IsAvailable { get; set; }

        public Room? Room { get; set; }
    }
}
