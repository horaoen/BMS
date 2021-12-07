using System.Threading.Tasks;
using BMS.Database;
using BMS.Services.IRepository;

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
    }
}