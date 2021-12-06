using BMS.Models.Entities;
using BMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [ApiController]
    [Route("")]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService _reservationService;
        public ReservationController(
            ReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        
    }
}