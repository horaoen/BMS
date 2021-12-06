using BMS.Services.IRepository;

namespace BMS.Services
{
    public class ReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IBookTitleRepository _bookTitleRepository;
        
        public ReservationService(
            IReservationRepository reservationRepository,
            IBookTitleRepository bookTitleRepository)
        {
            _reservationRepository = reservationRepository;
            _bookTitleRepository = bookTitleRepository;
        }
        
        
    }
}