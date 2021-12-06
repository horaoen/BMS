using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BMS.Models.Entities;

namespace BMS.Services.IRepository
{
    public interface IBookTitleRepository
    {
        Task<IEnumerable<BookTitle>> GetBookTitles();
        Task<BookTitle?> GetBookTitleByIdAsync(Guid bookTitleId);
        Task AddBookTitleAsync(BookTitle bookTitle);
    }
}