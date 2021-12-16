using System;
using System.Threading.Tasks;
using BMS.Models.Entities;
using BMS.Services.IRepository;

namespace BMS.Services
{
    public class ReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IBookTitleRepository _bookTitleRepository;
        private readonly ILoanRepository _loanRepository;
        private readonly IBookTitleItemRepository _bookTitleItemRepository;
        public ReservationService(
            IReservationRepository reservationRepository,
            IBookTitleRepository bookTitleRepository,
            ILoanRepository loanRepository, 
            IBookTitleItemRepository bookTitleItemRepository)
        {
            _reservationRepository = reservationRepository;
            _bookTitleRepository = bookTitleRepository;
            _loanRepository = loanRepository;
            _bookTitleItemRepository = bookTitleItemRepository;
        }

        public async Task<bool> HandleReservation(Guid reservationsId, bool isLoan)
        {
            var reservationFromRepo = await _reservationRepository.GetReservationByIdAsync(reservationsId);
            if (reservationFromRepo == null) return false;
            if (isLoan)
            {
                var loanBook = await _bookTitleItemRepository.FindIsNotLoanedBookAsync();
                if (loanBook == null) return false;

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
                
                _reservationRepository.DeleteReservation(reservationFromRepo);

                await _loanRepository.AddLoanAsync(loan);
            }
            else
            {
                _reservationRepository.DeleteReservation(reservationFromRepo);
            }

            return true;
        }
        
    }
}