using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Song
    {
        public virtual Album Album { get; set; }
        public int Id {get; set;}
        public string SongName { get; set; }
    }
}
