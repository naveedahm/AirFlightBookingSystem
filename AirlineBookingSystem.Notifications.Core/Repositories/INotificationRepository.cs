using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineBookingSystem.Notifications.Core.Repositories
{
    public interface INotificationRepository
    {
        Task LogNotificationAsync();
    }
}
