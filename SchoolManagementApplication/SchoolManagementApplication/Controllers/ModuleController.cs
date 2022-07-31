using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplication.Data;
using SchoolManagementApplication.Models;

namespace SchoolManagementApplication.Controllers
{
    public class ModuleController : Controller
    {
        public ApplicationDbContext _db;
        public ModuleController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Module> ModulesList = _db.modules;
            return View(ModulesList);
        }
        //GET
        public IActionResult Create()
        {
            ViewData["CodeSector"] = new SelectList(_db.sectors, "Code", "Code");
            return View();
        }
        //SET
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Module obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Module created succefully";
            return RedirectToAction("Index");
        }
        //GET
        public IActionResult Edit(string code)
        {
            if (code == null)
            {
                return NotFound();
            }
            var ModuleFromDb = _db.modules.Find(code);
            if (ModuleFromDb == null)
            {
                return NotFound();
            }
            return View(ModuleFromDb);
        }
        //SET
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Module obj)
        {
            _db.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Module Edited succefully";
            return RedirectToAction("Index");
        }
        //GET
        public IActionResult Delete(string code)
        {
            if (code == null)
            {
                return NotFound();
            }
            var ModuleFromDb = _db.modules.Find(code);
            if (ModuleFromDb == null)
            {
                return NotFound();
            }
            return View(ModuleFromDb);
        }
        //SET
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete(Module obj)
        {
            _db.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Module deleted succefully";
            return RedirectToAction("Index");
        }
    }
}
