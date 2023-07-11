using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        // GET: api/Musics
        [HttpGet]
        public IActionResult Get()
        {
            var musics = _context.Musics.ToList();
            return Ok(musics);
        }



        // GET api/Musics/5

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var music = _context.Musics.FirstOrDefault(m => m.Id == id);
            if (music == null)
            {
                return NotFound(); // Returns NotFound when there is no music with such id
            }
            return Ok(music); // Returns 200 status code


        }


        // POST api/<MusicsController>
        [HttpPost]
        public IActionResult Post([FromBody] Music music)
        {
            _context.Musics.Add(music);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = music.Id }, music); // Returns 201 status code
        }





        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Music music)
        {

            var existingMusic = _context.Musics.FirstOrDefault(m => m.Id == id);
            if (existingMusic == null)
            {
                return NotFound();
            }

            existingMusic.Title = music.Title;
            existingMusic.Artist = music.Artist;
            existingMusic.Genre = music.Genre;
            _context.SaveChanges();
            return Ok(existingMusic); // Returns 200 status code

        }





        // DELETE api/<MusicsController>/5


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var music = _context.Musics.FirstOrDefault(m => m.Id == id);
            if (music == null)
            {
                return NotFound();
            }
            _context.Musics.Remove(music);
            _context.SaveChanges();
            return NoContent(); // Returns NoContent status code


        }
    }
}

