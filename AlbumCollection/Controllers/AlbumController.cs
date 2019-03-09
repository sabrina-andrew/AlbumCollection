using AlbumCollection.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    public class AlbumController : Controller
    {
        IAlbumRepository albumRepo;

        public AlbumController(IAlbumRepository albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        public ViewResult Index()
        {
            var model = albumRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = albumRepo.GetByID(id);
            return View(model);
        }
    }
}
