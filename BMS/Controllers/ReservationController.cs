using System.Threading.Tasks;
using AutoMapper;
using BMS.Models.Entities;
using BMS.Services;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService _reservationService;
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository; 
        public ReservationController(
            ReservationService reservationService, 
            IMapper mapper,
            IReservationRepository reservationRepository)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _reservationRepository = reservationRepository;
        }

        // [HttpGet]
        // [Authorize(Roles = "SuperAdmin Admin")]
        // public Task<IActionResult> GetAllReservations()
        // {
        //     var reservationsFromRepo = _reservationRepository.GetAllReservationAsync();
        // }
    }
}