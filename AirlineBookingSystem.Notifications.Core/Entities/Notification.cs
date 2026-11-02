using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineBookingSystem.Notifications.Core.Entities
{
    internal class Notification
    {
        public Guid Id { get; set; }

        public string Recipient { get; set; }

        public string Message { get; set; }

        public string Type { get; set; }    // Email, SMS etc.
    }
}
