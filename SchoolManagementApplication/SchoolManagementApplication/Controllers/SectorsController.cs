using Microsoft.AspNetCore.Mvc;
using SchoolManagementApplication.Data;
using SchoolManagementApplication.Models;

namespace SchoolManagementApplication.Controllers
{
    public class SectorsController : Controller
    {
        public ApplicationDbContext _db;
        public SectorsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Sector> StudentsList = _db.sectors;
            return View(StudentsList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //SET
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Sector obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Sector created succefully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Edit(string code)
        {
            if (code == null)
            {
                return NotFound();
            }
            var SectorFromDb = _db.sectors.Find(code);
            if (SectorFromDb == null)
            {
                return NotFound();
            }
            return View(SectorFromDb);
        }
        //SET
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Sector obj)
        {
            if (ModelState.IsValid)
            {
                _db.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Sector created succefully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Delete(string code)
        {
            if (code == null)
            {
                return NotFound();
            }
            var SectorFromDb = _db.sectors.Find(code);
            if (SectorFromDb == null)
            {
                return NotFound();
            }
            return View(SectorFromDb);
        }
        //SET
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete(Sector obj)
        {
            _db.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Sector deleted succefully";
            return RedirectToAction("Index");
        }
    }
}
