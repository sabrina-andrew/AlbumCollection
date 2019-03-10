using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album GetByID(int id);
    }
}
