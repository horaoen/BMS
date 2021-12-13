﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BMS.Models.Entities;

namespace BMS.Services.IRepository
{
    public interface IBookTitleRepository
    {
        Task<IEnumerable<BookTitle>> GetBookTitlesAsync(string? keyword);
        Task<BookTitle?> GetBookTitleByIdAsync(Guid bookTitleId);
        Task AddBookTitleAsync(BookTitle bookTitle);
        Task<bool> SaveAsync();
        void DeleteBookTitle(BookTitle bookTitle);
        void DeleteBookTitleItem(BookTitleItem bookTitleItem);
        Task<BookTitleItem?> GetBookTitleItem(Guid bookTitleItemId);
        Task<IEnumerable<BookTitle>> GetBookTitleByIdsAsync(IEnumerable<Guid> bookTitleIds);
        void DeleteBookTitles(IEnumerable<BookTitle> bookTitles);
    }
}