using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BMS.Models.Entities;
using NLog.LayoutRenderers;

namespace BMS.Services.IRepository
{
    public interface IBookTitleItemRepository
    {
        Task<BookTitleItem?> FindIsNotLoanedBookAsync(Guid bookTitleId);
        Task<IEnumerable<BookTitleItem>> GetBookTitleItemsByTitleIdAsync(Guid bookTitleId);
        void DeleteBookTitleItems(IEnumerable<BookTitleItem> bookTitleItems);
        void DeleteBookTitleItem(BookTitleItem bookTitleItem);
    }
}