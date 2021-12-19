using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.Database;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BMS.Services.Repository
{
    public class BookTitleItemRepository : IBookTitleItemRepository
    {
        private readonly AppDbContext _context;
        public BookTitleItemRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<BookTitleItem?> FindIsNotLoanedBookAsync(Guid bookTitleId)
        {
            return await _context.BookTitleItems.FirstOrDefaultAsync(item => item.IsBorrowed == false && item.BookTitleId == bookTitleId);
        }

        public async Task<IEnumerable<BookTitleItem>> GetBookTitleItemsByTitleIdAsync(Guid bookTitleId)
        {
            return await _context.BookTitleItems
                .Where(bookTitleItem => bookTitleItem.BookTitleId == bookTitleId)
                .ToListAsync();
        }

        public void DeleteBookTitleItems(IEnumerable<BookTitleItem> bookTitleItems)
        {
            _context.BookTitleItems.RemoveRange(bookTitleItems);
        }
        

        public void DeleteBookTitleItem(BookTitleItem bookTitleItem)
        {
            _context.BookTitleItems.Remove(bookTitleItem);
        }
        

        public async Task<BookTitleItem?> GetBookTitleItem(Guid bookTitleItemId)
        {
            return await _context.BookTitleItems.FirstOrDefaultAsync(bookTitleItem => bookTitleItem.Id == bookTitleItemId);
        }
    }
}