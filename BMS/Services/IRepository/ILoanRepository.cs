using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BMS.Models.Entities;

namespace BMS.Services.IRepository
{
    public interface ILoanRepository
    {
        Task AddLoanAsync(Loan loan);

        Task<bool> SaveAsync();
        Task<Loan?> GetLoanByIdAsync(Guid loanId);
        void DeleteLoan(Loan loan);
        Task<IEnumerable<Loan>> GetLoansByBorrowerId(string? borrowerId);
    }
}