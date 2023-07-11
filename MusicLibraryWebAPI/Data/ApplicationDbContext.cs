using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Models;

namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Music> Musics { get; set; }
       public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        internal IActionResult FirstOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}
