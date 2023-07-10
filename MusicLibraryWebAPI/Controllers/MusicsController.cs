using Microsoft.AspNetCore.Mvc;
using MusicLibraryWebAPI.Data;
using MusicLibraryWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public MusicsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<MusicsController>
        [HttpGet]
        public IActionResult Get()
        {
            var musics = _context.Musics.ToList();
            return Ok(musics);
        }

        // GET api/<MusicsController>/5

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicsController>
        [HttpPost]
        public IActionResult Post([FromBody] Music music)
        {
            _context.Musics.Add(music);
            _context.SaveChanges();
            return StatusCode(201, music);
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
