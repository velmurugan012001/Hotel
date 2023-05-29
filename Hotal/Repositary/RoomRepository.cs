using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotal.Model;
using HotelAss.Model;
using Management.Repositary;
using Microsoft.EntityFrameworkCore;

namespace Hotal.Repository
{
     

    // A class that implements the room repository interface using Entity Framework Core
    public class RoomRepository : IRoomRepository
    {
        // A private field to store the database context
        private readonly HotelDbContext _context;

        // A constructor that injects the database context
        public RoomRepository(HotelDbContext context)
        {
            _context = context;
        }

        // Get all rooms
        public async Task<IEnumerable<Room>> GetRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        // Get a room by id
        public async Task<Room> GetRoom(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        // Add a new room
        public async Task AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        // Update an existing room
        public async Task UpdateRoom(int id, Room room)
        {
            if (id != room.RoomId)
            {
                throw new ArgumentException("The room id does not match the id parameter.");
            }

            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete a room by id
        public async Task DeleteRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                throw new KeyNotFoundException("The room with the specified id does not exist.");
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }
    }
}

