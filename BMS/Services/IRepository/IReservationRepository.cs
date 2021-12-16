using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BMS.Models.Entities;

namespace BMS.Services.IRepository
{
    public interface IReservationRepository
    {
        Task<bool> SaveAsync();
        Task<IEnumerable<Reservation>> GetAllReservationsAsync();
        Task<Reservation?> GetReservationByIdAsync(Guid reservationId);
        Task AddReservationAsync(Reservation reservation);
        void DeleteReservation(Reservation reservation);
        Task<Reservation?> GetReservationByBorrowerIdAsync(Guid borrowerId);
    }
}