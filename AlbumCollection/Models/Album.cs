using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int ReleaseYear { get; set; }
        public virtual List<Song> Songs { get; set; }

        public void Returns(Album expectedModel)
        {
            throw new NotImplementedException();
        }
    }
}
