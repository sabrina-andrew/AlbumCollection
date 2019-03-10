using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;


namespace AlbumCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SabrinaAndrewAlbums;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    AlbumId = 1,
                    Artist = "Carl Franklin",
                    ReleaseYear = 2015,
                    Title = "Music to Code By"
                },
                
                new Album()
                {
                    AlbumId = 2,
                    Artist = "Tycho",
                    ReleaseYear = 2016,
                    Title = "Epoch"
                },
                
                new Album()
                {
                    AlbumId = 3,
                    Artist = "Megadeth",
                    ReleaseYear = 1994,
                    Title = "Youthanasia"
                }
                );


            modelBuilder.Entity<Song>().HasData(

               new Song() { SongId = 1, AlbumId = 1, SongName = "Blue" },
               new Song() { SongId = 2, AlbumId = 1, SongName = "Red"},
               new Song() { SongId = 3, AlbumId = 1, SongName = "Orange" },
               new Song() { SongId = 4, AlbumId = 2, SongName = "From Home"},
               new Song() { SongId = 5, AlbumId = 2, SongName = "Sunrise Projector"},
               new Song() { SongId = 6, AlbumId = 3, SongName = "Reckoning Day"},
               new Song() { SongId = 7, AlbumId = 3, SongName = "Train of Consequences" },
               new Song() { SongId = 8, AlbumId = 3, SongName = "Addicted To Chaos" },
               new Song() { SongId = 9, AlbumId = 3, SongName = "A Tout le Monde"}
               );

               base.OnModelCreating(modelBuilder);
        }
    }
}
