using System;
using System.Collections.Generic;

namespace MusicApp.Models
{
    public partial class Albums
    {
        public Albums()
        {
            Songs = new HashSet<Songs>();
        }

        public int Id { get; set; }
        public string AlbumName { get; set; }
        public string Genre { get; set; }
        public int NumberOfRatings { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string RecordLabel { get; set; }
        public string CoverImage { get; set; }
        public string Review { get; set; }
        public int? ArtistId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Rating { get; set; }

        public Artists Artist { get; set; }
        public ICollection<Songs> Songs { get; set; }
    }
}
