
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.Database;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BMS.Services.Repository
{
    public class LoanRepository : ILoanRepository
    {
        private readonly AppDbContext _context;
        public LoanRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddLoanAsync(Loan loan)
        {
            await _context.Loans.AddAsync(loan);
        }

        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public async Task<Loan?> GetLoanByIdAsync(Guid loanId)
        {
            return await _context.Loans
                .Include(loan => loan.Borrower)
                .Include(loan => loan.LoanBook)
                .ThenInclude(bookTitleItem => bookTitleItem.BookTitle)
                .FirstOrDefaultAsync(loan => loan.Id == loanId);
        }

        public void DeleteLoan(Loan loan)
        {
            _context.Loans.Remove(loan);
        }

        public Task<IEnumerable<Loan>> GetLoansByBorrowerId(Guid borrowerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Loan>> GetLoans(string? borrowerId)
        {
            if (String.IsNullOrWhiteSpace(borrowerId)) return await _context.Loans.Take(100).ToListAsync();
            return await _context.Loans.Where(loan => loan.BorrowerId == borrowerId).Take(100).ToListAsync();
        }
    }
}