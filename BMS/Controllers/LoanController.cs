using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;
        public LoanController(
            ILoanRepository loanRepository,
            IMapper mapper)
        {
            _loanRepository = loanRepository;
            _mapper = mapper;
        }
        
    }
}