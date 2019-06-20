using System;
using System.Collections.Generic;

namespace MusicApp.Models
{
    public partial class Songs
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
        public string SongName { get; set; }
        public TimeSpan SongLength { get; set; }
        public int Listens { get; set; }
        public int SongNumber { get; set; }
        public decimal? Price { get; set; }

        public Albums Album { get; set; }
        public Artists Artist { get; set; }
    }
}
