using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Dtos;
using BMS.Helper;
using BMS.Models.Entities;
using BMS.ResourceParameters;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTitleController : ControllerBase
    {
        private readonly IBookTitleRepository _bookTitleRepository;
        private readonly IMapper _mapper;
        
        public BookTitleController(
            IBookTitleRepository bookTitleRepository,
            IMapper mapper)
        {
            _bookTitleRepository = bookTitleRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// 获取全部书目
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetBookTitles([FromQuery] BookTitleResourceParamaters? paramaters)
        {
            var bookTitlesFromRepo = await _bookTitleRepository.GetBookTitlesAsync(paramaters?.Keyword);
            if (!bookTitlesFromRepo.Any())
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<BookTitleDto>>(bookTitlesFromRepo));
        }

        /// <summary>
        /// 通过书目Id获取书目
        /// </summary>
        /// <param name="bookTitleId"></param>
        /// <returns></returns>
        [HttpGet("{bookTitleId:Guid}", Name = "GetBookTitleById")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBookTitleById(
            [FromRoute] Guid bookTitleId)
        {
            var bookTitleFromRepo = await _bookTitleRepository.GetBookTitleByIdAsync(bookTitleId);
            if (bookTitleFromRepo == null)
            {
                return NotFound("没有这本书");
            }

            return Ok(_mapper.Map<BookTitleDto>(bookTitleFromRepo));
        } 
        
        /// <summary>
        /// 创建书目
        /// </summary>
        /// <param name="bookTitleForCreationDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "SuperAdmin")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> CreateBookTitle(
            [FromBody] BookTitleForCreationDto bookTitleForCreationDto)
        {
            var bookTitle = _mapper.Map<BookTitle>(bookTitleForCreationDto);
            bookTitle.InitBookItems();
            await _bookTitleRepository.AddBookTitleAsync(bookTitle);
            await _bookTitleRepository.SaveAsync();
            return CreatedAtAction(
                "GetBookTitleById", 
                new { bookTitleId = bookTitle.Id }, 
                _mapper.Map<BookTitleDto>(bookTitle));
        }

        
        // [HttpPatch]
        // [Authorize(Roles = "SuperAdmin")]
        // public async Task<IActionResult> PartiallyUpdateBookTitle(
        //     [FromRoute] Guid bookTitleId,
        //     [FromBody] JsonPatchDocument<BookTitleForUpdateDto> patchDocument)
        // {
        //     var bookTitleFromRepo = await _bookTitleRepository.GetBookTitleByIdAsync(bookTitleId);
        //     if (bookTitleFromRepo == null)
        //     {
        //         return NotFound("不存在该书目");
        //     }
        //
        //     var bookTitleToPacth = _mapper.Map<BookTitleForUpdateDto>(bookTitleFromRepo);
        //     patchDocument.ApplyTo((bookTitleToPacth), ModelState);
        //
        //     if (!TryValidateModel(bookTitleToPacth))
        //     {
        //         return ValidationProblem(ModelState);
        //     }
        //     _mapper.Map(bookTitleToPacth, bookTitleFromRepo); 
        //     await _bookTitleRepository.SaveAsync();
        //     return NoContent();
        // }

        /// <summary>
        /// 删除书目
        /// </summary>
        /// <param name="bookTitleId"></param>
        /// <returns></returns>
        [HttpDelete("{bookTitleId}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> DeleteBookTitle([FromRoute] Guid bookTitleId)
        {
            var bookTitleFromRepo = await _bookTitleRepository.GetBookTitleByIdAsync(bookTitleId);
            if (bookTitleFromRepo == null)
            {
                return NotFound("未找到该书目");
            }
            _bookTitleRepository.DeleteBookTitle(bookTitleFromRepo);
            await _bookTitleRepository.SaveAsync();
            return NoContent();
        }

        /// <summary>
        /// 批量删除书目
        /// </summary>
        /// <param name="bookTitleIds"></param>
        /// <returns></returns>
        [HttpDelete("({bookTitleIds})")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> DeleteBookTitleByIds(
            [ModelBinder(BinderType = typeof(ArrayModelBinder))][FromRoute] IEnumerable<Guid>? bookTitleIds)
        {
            if (bookTitleIds == null)
            {
                return BadRequest();
            }

            var bookTitlesFromRepo = await _bookTitleRepository.GetBookTitleByIdsAsync(bookTitleIds);
            _bookTitleRepository.DeleteBookTitles(bookTitlesFromRepo);
            await _bookTitleRepository.SaveAsync();
            return NoContent();
        }
    }
}