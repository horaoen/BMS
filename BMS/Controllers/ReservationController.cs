using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.OpenApi.Validations;

namespace BMS.Controllers
{
    [ApiController]
    [Route("api/reservations")]
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
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetReservations()
        {
            var userRole = _reservationService.GetUserRole();
            if (string.IsNullOrWhiteSpace(userRole)) return BadRequest();
            if (userRole == "Borrower")
            {
                var borrowerId = _reservationService.GetUserId();
                if (string.IsNullOrWhiteSpace(borrowerId))
                {
                    return BadRequest();
                }
                var reservationsFromRepoByBorrowerId = await _reservationRepository.GetReservationsByBorrowerIdAsync(borrowerId);
                return Ok(_mapper.Map<IEnumerable<ReservationDto>>(reservationsFromRepoByBorrowerId));
            }
            var reservationsFromRepo = await _reservationRepository.GetAllReservationsAsync();
            if (!reservationsFromRepo.Any())
            {
                return NotFound("未找到预约信息");
            }
            return Ok(_mapper.Map<IEnumerable<ReservationDto>>(reservationsFromRepo));
        }


        /// <summary>
        /// 通过reservationId获取单条预约信息
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        [HttpGet("{reservationId:Guid}", Name = "GetReservationById")]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public async Task<IActionResult> GetReservationById([FromRoute] Guid reservationId)
        {
            var reservationFromRepo = await _reservationRepository.GetReservationByIdAsync(reservationId);
            if (reservationFromRepo == null) return NotFound("没有该reservation");
            return Ok(_mapper.Map<ReservationDto>(reservationFromRepo));
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
            if (string.IsNullOrWhiteSpace(userId))
            {
                return BadRequest();
            }

            reservation.BorrowerId = userId;
            await _reservationRepository.AddReservationAsync(reservation);
            await _reservationRepository.SaveAsync();
            return CreatedAtAction(
                "GetReservationById",
                new { reservationId = reservation.Id },
                _mapper.Map<ReservationDto>(reservation));
        }
        
        /// <summary>
        /// 处理预约
        /// </summary>
        /// <param name="reservationId"></param>
        /// <param name="isLoan"></param>
        /// <returns></returns>
        [HttpDelete("{reservationId:Guid}")]
        [Authorize(Roles = "SuperAdmin, Admin")]
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
                var reservationsFromRepo = await _reservationRepository.GetReservationsByBorrowerIdAsync(userId);
                var reservationFromRepo = reservationsFromRepo.FirstOrDefault(reservation => reservation.Id == reservationId);
                if (reservationFromRepo == null) return NotFound("没有这条预约信息");
                _reservationRepository.DeleteReservation(reservationFromRepo);
                return Ok("取消预约成功");
            }

            if (isLoan == null)
            {
                return BadRequest();
            }
            
            var res = await _reservationService.HandleReservation(reservationId, isLoan.Value);
            if (res == false)
            {
                return BadRequest("请检查reservationId是否正确");
            }
            else return Ok("预约成功");
        }
    }
}