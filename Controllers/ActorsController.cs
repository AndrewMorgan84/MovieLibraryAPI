using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLibraryAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Controllers
{
    [Route("api/actors")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ActorsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ActorDTO>>> Get()
        {
            var actors = await _context.Actors.ToListAsync();
            return _mapper.Map<List<ActorDTO>>(actors);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ActorDTO>> Get(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            if(actor == null)
            {
                return NotFound();
            }

            return _mapper.Map<ActorDTO>(actor);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] ActorCreationDTO actorCreationDTO)
        {
            return NoContent();
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ActorCreationDTO actorCreationDTO)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            if (actor == null)
            {
                return NotFound();
            }

            _context.Remove(actor);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
