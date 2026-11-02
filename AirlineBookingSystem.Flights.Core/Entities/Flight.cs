using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineBookingSystem.Flights.Core.Entities
{
    internal class Flight
    {
        public Guid Id { get; set; }

        public string FlightNumber { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

    }
}
