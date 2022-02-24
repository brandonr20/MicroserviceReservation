using MicroserviceReservation.DbContexts;
using MicroserviceReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceReservation.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ReservationContext _dbContext;

        public ReservationRepository(ReservationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation GetReservationByID(int ReservationId)
        {
            return _dbContext.Reservations.Find(ReservationId);
        }

        public IEnumerable<Reservation> GetReservationsByAirline(string AirlineName)
        {
            return _dbContext.Reservations.Join(_dbContext.Airlines, reservation => reservation.AirlineId, airline => airline.Id, (reservation, airline) => new {
                Reservation = reservation,
                Airline = airline
            }).Where(x => x.Airline.Name == AirlineName).Select(x => x.Reservation);
        }

        public void InsertReservation(Reservation reservation)
        {
            _dbContext.Add(reservation);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
