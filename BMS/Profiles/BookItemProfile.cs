using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;

namespace BMS.Profiles
{
    public class BookItemProfile : Profile
    {
        public BookItemProfile()
        {
            CreateMap<BookTitleItem, BookItemDto>();
        }
    }
}