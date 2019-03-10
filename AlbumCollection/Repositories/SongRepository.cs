using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class SongRepository : ISongRepository
    {
        AlbumContext db;
        public SongRepository(AlbumContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Songs.Count();
        }

        public void Create(Song song)
        {
            db.Songs.Add(song);
            db.SaveChanges();
        }
        public Song GetByID(int id)
        {
            return db.Songs.Single(song => song.SongId == id);
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public IEnumerable<Song> GetAll()
        {
            return db.Songs.ToList();
        }

    }
}
