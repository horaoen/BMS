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
        
        public async Task<IEnumerable<BookTitle>> GetBookTitles()
        {
            return await _context.BookTitles.Include(bookTitle => bookTitle.BookItems).ToListAsync();
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
    }
}