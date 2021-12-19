using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.Database;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BMS.Services.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly  AppDbContext _context;

        public ReservationRepository(
            AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync()
        {
            return await _context.Reservations.ToListAsync();
        }

        public async Task<Reservation?> GetReservationByIdAsync(Guid reservationId)
        {
            return await _context.Reservations.FirstOrDefaultAsync(reservation => reservation.Id == reservationId);
        }

        public async Task AddReservationAsync(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
        }

        public void DeleteReservation(Reservation reservation)
        {
            _context.Reservations.Remove(reservation);
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByBorrowerIdAsync(string borrowerId)
        {
           return await _context.Reservations.Where(reservation => reservation.BorrowerId == borrowerId).ToListAsync();
        }
    }
}