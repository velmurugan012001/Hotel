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
    // A class that implements the reservation repository interface using Entity Framework Core
    public class ReservationRepository : IReservationRepository
    {
        // A private field to store the database context
        private readonly HotelDbContext _context;

        // A constructor that injects the database context
        public ReservationRepository(HotelDbContext context)
        {
            _context = context;
        }

        // Get all reservations
        public async Task<IEnumerable<Reservation>> GetReservations()
        {
            return await _context.Reservations.ToListAsync();
        }

        // Get a reservation by id
        public async Task<Reservation> GetReservation(int id)
        {
            return await _context.Reservations.FindAsync(id);
        }

        // Add a new reservation
        public async Task AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
        }

        // Update an existing reservation
        public async Task UpdateReservation(int id, Reservation reservation)
        {
            if (id != reservation.ReservationId)
            {
                throw new ArgumentException("The reservation id does not match the id parameter.");
            }

            _context.Entry(reservation).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Delete a reservation by id
        public async Task DeleteReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                throw new KeyNotFoundException("The reservation with the specified id does not exist.");
            }

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
        }
    }
}

