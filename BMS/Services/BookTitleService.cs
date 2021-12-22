using System.Threading.Tasks;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Http;

namespace BMS.Services.Repository
{
    public class BookTitleService : BaseService
    {
        private readonly IBookTitleRepository _bookTitleRepository;
        private readonly IBookTitleItemRepository _bookTitleItemRepository;

        public BookTitleService(
            IBookTitleRepository bookTitleRepository,
            IBookTitleItemRepository bookTitleItemRepository)
        {
            _bookTitleRepository = bookTitleRepository;
            _bookTitleItemRepository = bookTitleItemRepository;
        }

        public async Task DeleteBookTitle(BookTitle bookTitle)
        {
            var bookTitleItems = await _bookTitleItemRepository.GetBookTitleItemsByTitleIdAsync(bookTitle.Id);
            _bookTitleItemRepository.DeleteBookTitleItems(bookTitleItems);
            _bookTitleRepository.DeleteBookTitle(bookTitle);
            await _bookTitleRepository.SaveAsync();
        }

    }
}