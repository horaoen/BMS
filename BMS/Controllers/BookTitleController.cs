using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BMS.Dtos;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

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

        [HttpGet]
        public async Task<IActionResult> GetBookTitles()
        {
            var bookTitlesFromRepo = await _bookTitleRepository.GetBookTitles();
            if (!bookTitlesFromRepo.Any())
            {
                return NotFound($"没有书目，请添加");
            }

            return Ok(bookTitlesFromRepo);
        }

        [HttpGet("{bookTitleId:Guid}", Name = "GetBookTitleById")]
        public async Task<IActionResult> GetBookTitleById(
            [FromRoute] Guid bookTitleId)
        {
            var bookTitleFromRepo = await _bookTitleRepository.GetBookTitleByIdAsync(bookTitleId);
            if (bookTitleFromRepo == null)
            {
                return NotFound("没有这本书");
            }

            return Ok(bookTitleFromRepo);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateBookTitle(
            [FromBody] BookTitleForCreationDto bookTitleForCreationDto)
        {
            var bootTitle = _mapper.Map<BookTitle>(bookTitleForCreationDto);
            _bookTitleRepository.AddBookTitleAsync(bootTitle);
            return 
        }
    }
}