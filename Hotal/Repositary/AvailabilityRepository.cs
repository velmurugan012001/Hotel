using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAss.Model;
using Management.Repositary;
using Microsoft.EntityFrameworkCore;

namespace Hotal.Repository
{
   

    // A class that implements the availability repository interface using Entity Framework Core
    public class AvailabilityRepository : IAvailabilityRepository
    {
        // A private field to store the database context
        private readonly HotelDbContext _context;

        // A constructor that injects the database context
        public AvailabilityRepository(HotelDbContext context)
        {
            _context = context;
        }

        // Get all availabilities
        public async Task<IEnumerable<Availability>> GetAvailabilities()
        {
            return await _context.Availabilities.ToListAsync();
        }

        // Get an availability by id
        public async Task<Availability> GetAvailability(bool id)
        {
            return await _context.Availabilities.FindAsync(id);
        }

        // Add a new availability
        public async Task AddAvailability(Availability availability)
        {
            _context.Availabilities.Add(availability);
            await _context.SaveChangesAsync();
        }

        // Update an existing availability
        public async Task UpdateAvailability(bool id, Availability availability)
        {
            if (id != availability.AvailabilityId)
            {
                throw new ArgumentException("The availability id does not match the id parameter.");
            }

            _context.Entry(availability).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete an availability by id
        public async Task DeleteAvailability(bool id)
        {
            var availability = await _context.Availabilities.FindAsync(id);
            if (availability == null)
            {
                throw new KeyNotFoundException("The availability with the specified id does not exist.");
            }

            _context.Availabilities.Remove(availability);
            await _context.SaveChangesAsync();
        }
    }
}
