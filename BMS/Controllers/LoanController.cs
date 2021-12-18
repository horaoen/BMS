using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Dtos;
using BMS.Services;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [Route("api/loans")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;
        private readonly LoanService _loanService;
        public LoanController(
            ILoanRepository loanRepository,
            IMapper mapper,
            LoanService loanService)
        {
            _loanRepository = loanRepository;
            _mapper = mapper;
            _loanService = loanService;
        }
        
        /// <summary>
        /// 查看借阅记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetLoans()
        {
            var userRole = _loanService.GetUserRole();
            if (!string.IsNullOrWhiteSpace(userRole))
            {
                return BadRequest();
            }

            if (userRole == "Borrower")
            {
                var userId = _loanService.GetUserId();
                if (userId == null) return BadRequest();
                
                var loansFromRepo = await _loanRepository.GetLoansByBorrowerId(userId.Value.ToString());
                return Ok(_mapper.Map<IEnumerable<LoanDto>>(loansFromRepo));
            }

            return Ok(_mapper.Map<IEnumerable<LoanDto>>(await _loanRepository.GetLoansByBorrowerId("")));
        }

        
        /// <summary>
        /// 处理归还书籍
        /// </summary>
        /// <param name="loanId"></param>
        /// <returns></returns>
        [HttpDelete("{loanId:Guid}")]
        [Authorize(Roles = "SuperAdmin Admin")]
        public async Task<IActionResult> ReturnBook([FromRoute] Guid loanId)
        {
            var res = await _loanService.HandleReturn(loanId);
            return NoContent();
        }
    }
}