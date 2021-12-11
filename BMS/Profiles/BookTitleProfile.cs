using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;

namespace BMS.Profiles
{
    public class BookTitleProfile : Profile
    {
        public BookTitleProfile()
        {
            CreateMap<BookTitleForCreationDto, BookTitle>();
            CreateMap<BookTitle, BookTitleDto>()
                .ForMember(
                    dest => dest.RemaindBook,
                    opt => opt.MapFrom(src => src.TotalNumber - src.BorrowedNumber));
            CreateMap<BookTitle, BookTitleForUpdateDto>();
        }
    }
}