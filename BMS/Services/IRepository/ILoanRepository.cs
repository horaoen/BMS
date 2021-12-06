using System.Threading.Tasks;
using BMS.Models.Entities;

namespace BMS.Services.IRepository
{
    public interface ILoanRepository
    {
        Task AddLoanAsync(Loan loan);

        Task<bool> SaveAsync();
    }
}