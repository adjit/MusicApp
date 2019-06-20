using System;
using System.Collections.Generic;

namespace MusicApp.Models
{
    public partial class Artists
    {
        public Artists()
        {
            Albums = new HashSet<Albums>();
            Songs = new HashSet<Songs>();
        }

        public int Id { get; set; }
        public string ArtistName { get; set; }

        public ICollection<Albums> Albums { get; set; }
        public ICollection<Songs> Songs { get; set; }
    }
}
