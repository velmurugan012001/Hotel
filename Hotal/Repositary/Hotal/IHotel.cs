using Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public interface IHotel
{
    // Get all hotels
    Task<IEnumerable<Hotel>> GetHotels();

    // Get a hotel by id
    Task<Hotel> GetHotel(int id);

    // Add a new hotel
    Task AddHotel(Hotel hotel);

    // Update an existing hotel
    Task UpdateHotel(int id, Hotel hotel);

    // Delete a hotel by id
    Task DeleteHotel(int id);
    Task<List<Hotel>> FilterHotels(string location);
    // Task<List<Hotel>> FilterHotel(string location);
}


