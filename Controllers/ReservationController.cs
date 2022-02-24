using MicroserviceReservation.Models;
using MicroserviceReservation.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroserviceReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationController(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }
        // GET: api/<ReservationController>/GetByAirline/Avianca
        [HttpGet("GetByAirline/{name}")]
        public IActionResult GetByAirline(string name)
        {
            var reservation = _reservationRepository.GetReservationsByAirline(name);

            return new OkObjectResult(reservation);
        }

        // GET api/<ReservationController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var reservation = _reservationRepository.GetReservationByID(id);
            return new OkObjectResult(reservation);
        }

        // POST api/<ReservationController>
        [HttpPost]
        public IActionResult Post([FromBody] Reservation reservation)
        {
            using (var scope = new TransactionScope())
            {
                _reservationRepository.InsertReservation(reservation);
                scope.Complete();
                return CreatedAtAction(nameof(GetById), new { id = reservation.ReservationId }, reservation);
            }
        }
      
    }
}
