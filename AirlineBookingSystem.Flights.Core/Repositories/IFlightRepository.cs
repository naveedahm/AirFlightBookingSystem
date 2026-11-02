using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineBookingSystem.Flights.Core.Repositories
{
    public interface IFlightRepository
    {
        Task<IEnumerable<Flight>> GetFlightsAsync();

        Task AddFlightAsync(Flight flight);

        Task DeleteFlightAsync(Guid id);
    }
}
