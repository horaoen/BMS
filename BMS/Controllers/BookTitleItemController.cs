using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Services;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [ApiController]
    [Route("api/booktitles/{bookTitleId}/bookTitleItems")]
    public class BookItemController : ControllerBase
    {
        private readonly BookTitleItemService _bookTitleItemService;
        private readonly IBookTitleRepository _bookTitleRepository;
        private readonly IMapper _mapper;
        private readonly IBookTitleItemRepository _bookTitleItemRepository;
        public BookItemController(
            BookTitleItemService bookTitleItemService,
            IBookTitleRepository bookTitleRepository,
            IMapper mapper,
            IBookTitleItemRepository bookTitleItemRepository)
        {
            _bookTitleItemService = bookTitleItemService;
            _bookTitleRepository = bookTitleRepository;
            _mapper = mapper;
            _bookTitleItemRepository = bookTitleItemRepository;
        }

        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="bookTitleId"></param>
        /// <param name="bookTitleItemId"></param>
        /// <returns></returns>
        [HttpDelete("{bookTitleItemId:Guid}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> DeleteBookTitleItem(
            [FromRoute] Guid bookTitleId,
            [FromRoute] Guid bookTitleItemId)
        {
            var bookTitleFromRepo = await _bookTitleRepository.GetBookTitleByIdAsync(bookTitleId);
            
            if (bookTitleFromRepo == null)
            {
                return BadRequest("没有该书目");
            }

            var bookTitleItem = bookTitleFromRepo.BookItems
                .FirstOrDefault(bookTitleItem => bookTitleItem.Id == bookTitleItemId);

            if (bookTitleItem == null)
            {
                return BadRequest("没有该书籍");
            }
            await _bookTitleItemService.DeleteBookTitleItem(bookTitleItem);
            return NoContent();
        }
    }
}