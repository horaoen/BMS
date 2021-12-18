using System;
using System.Threading.Tasks;
using BMS.Models.Entities;

namespace BMS.Services.IRepository
{
    public interface IBookTitleItemRepository
    {
        Task<BookTitleItem?> FindIsNotLoanedBookAsync(Guid bookTitleId);
    }
}