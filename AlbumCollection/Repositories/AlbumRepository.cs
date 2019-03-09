using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        AlbumContext db;
        public AlbumRepository(AlbumContext db)
        {
            this.db = db;
        }

        public Album GetByID(int id)
        {
            return db.Albums.Single(album => album.Id == id);
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
        }
       
        public Album GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
