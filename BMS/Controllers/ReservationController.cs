using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;
using BMS.Services;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;

namespace BMS.Controllers
{
    [ApiController]
    [Route("api/reservation")]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService _reservationService;
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ReservationController(
            ReservationService reservationService, 
            IMapper mapper,
            IReservationRepository reservationRepository,
            IHttpContextAccessor httpContextAccessor)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _reservationRepository = reservationRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// 获取预约信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetReservations([FromQuery] string? keyword)
        {
            var reservationsFromRepo = await _reservationRepository.GetAllReservationsAsync();
            if (!reservationsFromRepo.Any())
            {
                return NotFound("未找到预约信息");
            }
            return Ok(_mapper.Map<IEnumerable<ReservationDto>>(reservationsFromRepo));
        }

        /// <summary>
        /// 添加预约信息
        /// </summary>
        /// <param name="reservationForCreation"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> AddReservation([FromBody] ReservationForCreation reservationForCreation)
        {
            var reservation = _mapper.Map<Reservation>(reservationForCreation);
            var userId = _reservationService.GetUserId();
            if (userId == null)
            {
                return BadRequest();
            }
            reservation.BorrowerId = userId.Value;
            await _reservationRepository.AddReservationAsync(reservation);
            await _reservationRepository.SaveAsync();
            return NoContent();
        }
        
        
        /// <summary>
        /// 处理预约
        /// </summary>
        /// <param name="reservationId"></param>
        /// <param name="isLoan"></param>
        /// <returns></returns>
        [HttpDelete("{reservationId:Guid}")]
        [Authorize(Roles = "SuperAdmin Admin")]
        public async Task<IActionResult> HandleReservation(
            [FromRoute] Guid reservationId, 
            [FromBody] bool? isLoan)
        {
            var role = _reservationService.GetUserRole();
            if (role == "Borrower")
            {
                var userId = _reservationService.GetUserId();
                if (userId == null)
                {
                    return BadRequest();
                }
                var reservationFromRepo = await _reservationRepository.GetReservationByBorrowerIdAsync(userId.Value);
                if (reservationFromRepo == null) return BadRequest("请检查reservationId是否正确");
                _reservationRepository.DeleteReservation(reservationFromRepo);
                return NoContent();
            }

            if (isLoan == null)
            {
                return BadRequest();
            }
            
            var res = await _reservationService.HandleReservation(reservationId, isLoan.Value);
            if (res)
            {
                return BadRequest("请检查reservationId是否正确");
            }
            else return NoContent();
        }
    }
}