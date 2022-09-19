using Microsoft.AspNetCore.Mvc;
using WatchBackWeb.Data;
using WatchBackWeb.Models;

namespace WatchBackWeb.Controllers
{
    public class CameraController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CameraController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Camera> objCameraList = _db.Cameras;
            return View(objCameraList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Camera obj)
        {
            if(ModelState.IsValid)
            {
            _db.Cameras.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
