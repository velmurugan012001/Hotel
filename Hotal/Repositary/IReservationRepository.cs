namespace Management.Repositary
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetReservations();

        // Get a reservation by id
        Task<Reservation> GetReservation(int id);

        // Add a new reservation
        Task AddReservation(Reservation reservation);

        // Update an existing reservation
        Task UpdateReservation(int id, Reservation reservation);

        // Delete a reservation by id
        Task DeleteReservation(int id);
    }
}
