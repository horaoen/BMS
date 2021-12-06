using System.Threading.Tasks;
using BMS.Models.Entities;
using BMS.Services.IRepository;

namespace BMS.Services.Repository
{
    public class LoanRepository : ILoanRepository
    {
        public Task AddLoanAsync(Loan loan)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}