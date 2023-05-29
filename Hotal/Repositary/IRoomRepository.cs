namespace Management.Repositary
{
    public interface IRoomRepository
    {
        // Get all rooms
        Task<IEnumerable<Room>> GetRooms();

        // Get a room by id
        Task<Room> GetRoom(int id);

        // Add a new room
        Task AddRoom(Room room);

        // Update an existing room  
        Task UpdateRoom(int id, Room room);

        // Delete a room by id
        Task DeleteRoom(int id);
    }
}
