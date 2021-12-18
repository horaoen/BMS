using System;
using System.Threading.Tasks;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BMS.Services
{
    public class LoanService : BaseService
    {
        private readonly ILoanRepository _loanRepository;

        public LoanService(
            IHttpContextAccessor httpContextAccessor,
            ILoanRepository loanRepository) : base(httpContextAccessor)
        {
            _loanRepository = loanRepository;
        }

        public async Task<bool> HandleReturn(Guid loanId)
        {
            var loanFromRepo = await _loanRepository.GetLoanByIdAsync(loanId);
            if (loanFromRepo == null) return false;
            var borrower = loanFromRepo.Borrower;
            var loanBook = loanFromRepo.LoanBook;
            var returnTime = new DateTime();
            borrower.Fine += (returnTime > loanFromRepo.ReturnDate ? (returnTime - loanFromRepo.ReturnDate).Days : 0);
            loanBook.IsBorrowed = false;
            loanBook.BookTitle.BorrowedNumber--;
            _loanRepository.DeleteLoan(loanFromRepo);
            await _loanRepository.SaveAsync();
            return true;
        }
    }
}