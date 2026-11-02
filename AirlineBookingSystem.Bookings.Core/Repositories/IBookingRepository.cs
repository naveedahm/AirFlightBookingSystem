using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineBookingSystem.Notifications.Core.Repositories
{
    public interface IBookingRepository
    {
        Task<Booking> GetBookingByIdAsync(Guid id);

        Task AddBookingAsync(Booking booking);
    }
}
