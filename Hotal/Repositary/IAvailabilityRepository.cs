namespace Management.Repositary
{
    public interface IAvailabilityRepository
    {
        // Get all availabilities
        Task<IEnumerable<Availability>> GetAvailabilities();

        // Get an availability by id
        Task<Availability> GetAvailability(bool id);

        // Add a new availability
        Task AddAvailability(Availability availability);

        // Update an existing availability
        Task UpdateAvailability(bool id, Availability availability);

        // Delete an availability by id
        Task DeleteAvailability(bool id);
    }
}
