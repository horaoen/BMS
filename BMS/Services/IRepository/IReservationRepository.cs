using System.Threading.Tasks;

namespace BMS.Services.IRepository
{
    public interface IReservationRepository
    {
        Task<bool> SaveAsync();
    }
}