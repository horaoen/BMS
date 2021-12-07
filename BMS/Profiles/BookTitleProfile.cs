using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;

namespace BMS.Profiles
{
    public class BookTitleProfile : Profile
    {
        public BookTitleProfile()
        {
            CreateMap<BookTitle, BookTitleDto>();
            CreateMap<BookTitleForCreationDto, BookTitle>();
            CreateMap<BookTitle, BookTitleDto>()
                .ForMember(
                    dest => dest.RemaindBook,
                    opt => opt.MapFrom(src => src.TotalNumber - src.BorrowedNumber));
        }
    }
}