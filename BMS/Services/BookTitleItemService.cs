using System.Collections;
using System.Threading.Tasks;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Http;

namespace BMS.Services
{
    public class BookTitleItemService : BaseService
    {
        private readonly IBookTitleRepository _bookTitleRepository;
        private readonly IBookTitleItemRepository _bookTitleItemRepository;
        public BookTitleItemService(
            IBookTitleRepository bookTitleRepository,
            IBookTitleItemRepository bookTitleItemRepository)
        {
            _bookTitleRepository = bookTitleRepository;
            _bookTitleItemRepository = bookTitleItemRepository;
        }

        public async Task<bool> DeleteBookTitleItem(BookTitleItem bookTitleItem)
        {
            var bookTitleFromRepo = await _bookTitleRepository.GetBookTitleByIdAsync(bookTitleItem.BookTitleId);
            if (bookTitleFromRepo == null) return false;
            bookTitleFromRepo.TotalNumber--;
            _bookTitleItemRepository.DeleteBookTitleItem(bookTitleItem);
            return true;
        }
    }
}