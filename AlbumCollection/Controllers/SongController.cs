using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository songRepo;
        public SongController(ISongRepository songRepo)
        {
            this.songRepo = songRepo;
        }

        public ViewResult Index()
        {
            IEnumerable<Song> model = songRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = songRepo.GetByID(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            var newSong = new Song()
            {
                Id = id
            };

            return View(newSong);
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songRepo.Create(song);
            return RedirectToAction("../Album/Details/" + song.Id);
        }
    }
}
