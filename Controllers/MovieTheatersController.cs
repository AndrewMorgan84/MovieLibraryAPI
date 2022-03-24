using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLibraryAPI.DTOs;
using MovieLibraryAPI.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Controllers
{
    [Route("api/movieTheaters")]
    [ApiController]
    public class MovieTheatersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MovieTheatersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MovieTheaterDTO>>> Get()
        {
            var entities = await _context.MovieTheaters.OrderBy(mt => mt.Name).ToListAsync();
            return _mapper.Map<List<MovieTheaterDTO>>(entities);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<MovieTheaterDTO>> Get(int id)
        {
            var movieTheater = await _context.MovieTheaters.FirstOrDefaultAsync(mt => mt.Id == id);
            if(movieTheater == null)
            {
                return NotFound();
            }

            return _mapper.Map<MovieTheaterDTO>(movieTheater);
        }

        [HttpPost]
        public async Task<ActionResult> Post(MovieTheaterCreationDTO movieTheaterCreationDTO)
        {
            var movieTheater = _mapper.Map<MovieTheater>(movieTheaterCreationDTO);
            _context.Add(movieTheater);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, MovieTheaterCreationDTO movieTheaterCreationDTO)
        {
            var movieTheater = await _context.MovieTheaters.FirstOrDefaultAsync(mt => mt.Id == id);
            if (movieTheater == null)
            {
                return NotFound();
            }

            movieTheater = _mapper.Map(movieTheaterCreationDTO, movieTheater);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var movieTheater = await _context.MovieTheaters.FirstOrDefaultAsync(mt => mt.Id == id);
            if(movieTheater == null)
            {
                return NotFound();
            }

            _context.Remove(movieTheater);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
