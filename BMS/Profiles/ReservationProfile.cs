using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;

namespace BMS.Profiles
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, ReservationDto>();
            CreateMap<ReservationForCreation, Reservation>();
            CreateMap<ReservationForUpdate, Reservation>();
        }
    }
}