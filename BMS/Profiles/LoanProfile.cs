using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;

namespace BMS.Profiles
{
    public class LoanProfile : Profile
    {
        public LoanProfile()
        {
            CreateMap<Loan, LoanDto>();
        }
    }
}