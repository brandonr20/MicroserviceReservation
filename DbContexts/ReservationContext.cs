using MicroserviceReservation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceReservation.DbContexts
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airline> Airlines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>().HasData(
                //Airport Default
                new Airport
                {
                    Id = 1,
                    Name = "José María Córdova"
                },
                new Airport
                {
                    Id = 2,
                    Name = "El Dorado"
                },
                new Airport
                {
                    Id = 3,
                    Name = "Palonegro"
                },
                new Airport
                {
                    Id = 4,
                    Name = "El Eden"
                });


            modelBuilder.Entity<Airline>().HasData(
                //Airline Default
                new Airline
                {
                    Id = 1,
                    Name = "Avianca"
                },
                new Airline
                {
                    Id = 2,
                    Name = "LATAM"
                },
                new Airline
                {
                    Id = 3,
                    Name = "SATENA"
                },
                new Airline
                {
                    Id = 4,
                    Name = "Wingo"
                });
            

        }
    }
}
