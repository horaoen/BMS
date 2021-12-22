using System;
using System.Security.Claims;
using System.Threading.Tasks;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Http;

namespace BMS.Services
{
    public class ReservationService : BaseService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IBookTitleRepository _bookTitleRepository;
        private readonly ILoanRepository _loanRepository;
        private readonly IBookTitleItemRepository _bookTitleItemRepository;

        public ReservationService(
            ILoanRepository loanRepository,
            IBookTitleRepository bookTitleRepository,
            IBookTitleItemRepository bookTitleItemRepository,
            IReservationRepository reservationRepository)
        {
            _loanRepository = loanRepository;
            _reservationRepository = reservationRepository;
            _bookTitleRepository = bookTitleRepository;
            _bookTitleItemRepository = bookTitleItemRepository;
        }
        public async Task<bool> HandleReservation(Guid reservationsId, bool isLoan)
        {
            var reservationFromRepo = await _reservationRepository.GetReservationByIdAsync(reservationsId);
            if (reservationFromRepo == null) return false;
            if (isLoan)
            {
                var loanBook = await _bookTitleItemRepository.FindIsNotLoanedBookAsync(reservationFromRepo.BookTitleId);
                if (loanBook == null) return false;

                loanBook.IsBorrowed = true;
                var loanDate = new DateTime();
                var returnDate = loanDate + TimeSpan.FromDays(reservationFromRepo.LoanTime);

                var loan = new Loan()
                {
                    Id = new Guid(),
                    BorrowerId = reservationFromRepo.BorrowerId.ToString(),
                    LoanBookId = loanBook.Id,
                    LoanDate = loanDate,
                    ReturnDate = returnDate
                };
                var loanedBookTitle = await _bookTitleRepository.GetBookTitleByIdAsync(reservationFromRepo.BookTitleId);
                if (loanedBookTitle == null) return false;
                loanedBookTitle.BorrowedNumber++;
                _reservationRepository.DeleteReservation(reservationFromRepo);

                await _loanRepository.AddLoanAsync(loan);
            }
            else
            {
                _reservationRepository.DeleteReservation(reservationFromRepo);
            }

            await _reservationRepository.SaveAsync();
            return true;
        }

        
    }
}