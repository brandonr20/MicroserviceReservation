using MicroserviceReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceReservation.Repository
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> GetReservationsByAirline(string Airline);
        Reservation GetReservationByID(int ReservationId);
        void InsertReservation(Reservation reservation);
        void Save();
    }
}
