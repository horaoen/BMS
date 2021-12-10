using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;
using BMS.ResourceParameters;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> GetBookTitles([FromQuery] BookTitleResourceParamaters paramaters)
        {
            var bookTitlesFromRepo = await _bookTitleRepository.GetBookTitles(paramaters.Keyword);
            if (!bookTitlesFromRepo.Any())
            {
                return NotFound($"没有书目，请添加");
            }

            return Ok(_mapper.Map<IEnumerable<BookTitleDto>>(bookTitlesFromRepo));
        }

        /// <summary>
        /// 通过书目Id获取书目
        /// </summary>
        /// <param name="bookTitleId"></param>
        /// <returns></returns>
        [HttpGet("{bookTitleId:Guid}", Name = "GetBookTitleById")]
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
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> CreateBookTitle(
            [FromBody] BookTitleForCreationDto bookTitleForCreationDto)
        {
            var bookTitle = _mapper.Map<BookTitle>(bookTitleForCreationDto);
            for (var i = 0; i < bookTitleForCreationDto.TotalNumber; i++)
            {
                bookTitle.BookItems.Add(new BookItem(){ Id = new Guid() });
            }
            await _bookTitleRepository.AddBookTitleAsync(bookTitle);
            await _bookTitleRepository.SaveAsync();
            return CreatedAtAction(
                "GetBookTitleById", 
                new { bookTitleId = bookTitle.Id }, 
                _mapper.Map<BookTitleDto>(bookTitle));
        }
        
        // /// <summary>
        // /// 更新书目信息
        // /// </summary>
        // /// <returns></returns>
        // [HttpPatch]
        // [Authorize(AuthenticationSchemes = "Bearer")]
        // public async Task<IActionResult> UpdateBookTitle 
    }
}