using System.Collections;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Reservation>> GetAllReservationAsync()
        {
            return await _context.Reservations.ToListAsync();
        }
    }
}