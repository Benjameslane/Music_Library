using System.ComponentModel.DataAnnotations;

namespace MusicLibraryWebAPI.Models
{
    public class Music
    {

        // do one of these need to be taken out due to them being part of a collection?

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist{ get; set; }
        public string Album{ get; set; }
        public int ReleaseDate{ get; set; }
        public string Genre { get; set; }
    }
}

