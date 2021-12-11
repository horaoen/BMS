using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMS.Database;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BMS.Services.Repository
{
    public class BookTitleRepository : IBookTitleRepository
    {
        private readonly AppDbContext _context;

        public BookTitleRepository(
            AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<BookTitle>> GetBookTitles(string? keyword)
        {
            IQueryable<BookTitle> res = _context
                .BookTitles
                .Include(bookTitle => bookTitle.BookItems);
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();
                res = res.Where(b => b.Name.Contains(keyword));
            }
            return await res.ToListAsync();
        }

        public async Task<BookTitle?> GetBookTitleByIdAsync(Guid bookTitleId)
        {
            return await _context.BookTitles
                .Include(bookTitle => bookTitle.BookItems)
                .FirstOrDefaultAsync(bookTitle => bookTitle.Id == bookTitleId);
        }

        public async Task AddBookTitleAsync(BookTitle bookTitle)
        {
            await _context.BookTitles.AddAsync(bookTitle);
        }

        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public void DeleteBookTitle(BookTitle bookTitle)
        {
            _context.BookTitles.Remove(bookTitle);
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