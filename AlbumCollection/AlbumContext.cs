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
                });


            modelBuilder.Entity<Song>().HasData(

               new Song() { SongId = 1, AlbumId = 1, SongName = "Blue" },
               new Song() { SongId = 2, AlbumId = 1, SongName = "Red"},
               new Song() { SongId = 3, AlbumId = 1, SongName = "Orange" },
               new Song() { SongId = 4, AlbumId = 2, SongName = "From Home"},
               new Song() { SongId = 5, AlbumId = 2, SongName = "Sunrise Projector"}
               );

               base.OnModelCreating(modelBuilder);
        }
    }
}
