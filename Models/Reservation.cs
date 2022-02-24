using MicroserviceReservation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceReservation.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int AirportOriginId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int ArrivalAirportId { get; set; }
        public int FlightNumber { get; set; }
        public int AirlineId { get; set; }
        public double Price { get; set; }
        public PassengerType PassengerType { get; set; }
    }
}
