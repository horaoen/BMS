using System;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [ApiController]
    [Route("api/booktitles/{bookTitleId}/bookTitleItems")]
    public class BookItemController : ControllerBase
    {
        private readonly IBookTitleRepository _bookTitleRepository;
        private readonly IMapper _mapper;
        public BookItemController(
            IBookTitleRepository bookTitleRepository,
            IMapper mapper)
        {
            _bookTitleRepository = bookTitleRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="bookTitleId"></param>
        /// <param name="bookTitleItemId"></param>
        /// <returns></returns>
        [HttpDelete("{bookTitleItemId}")]
        public async Task<IActionResult> DeleteBookTitleItem(
            [FromRoute] Guid bookTitleId,
            [FromRoute] Guid bookTitleItemId)
        {
            var bookTitleItem = await _bookTitleRepository.GetBookTitleItem(bookTitleItemId);
            if (bookTitleItem == null)
            {
                return NotFound("未找到该书");
            }
            _bookTitleRepository.DeleteBookTitleItem(bookTitleItem);
            return NoContent();
        }
    }
}