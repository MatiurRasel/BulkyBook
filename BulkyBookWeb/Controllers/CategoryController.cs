
using BulkyBook.DataAccess;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Categories;

            return View(objList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                //ModelState.AddModelError("CustomError", "The Display order cannot exactly match the name.");
                ModelState.AddModelError("name", "The Display order cannot exactly match the name.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully...";
                return RedirectToAction("Index");
            }

            return View(obj);
        }
        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            { 
                return NotFound();
            
            }
            var categoryfromdb = _db.Categories.Find(id);
            //var categoryfromDbFirst = _db.Categories.SingleOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (categoryfromdb ==  null)
            {
                return NotFound();
            }


            return View(categoryfromdb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                //ModelState.AddModelError("CustomError", "The Display order cannot exactly match the name.");
                ModelState.AddModelError("name", "The Display order cannot exactly match the name.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully...";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
            var categoryfromdb = _db.Categories.Find(id);
            //var categoryfromDbFirst = _db.Categories.SingleOrDefault(c => c.Id == id);
            //var categoryFromDbSingle = _db.Categories.FirstOrDefault(c => c.Id == id);
            if (categoryfromdb == null)
            {
                return NotFound();
            }


            return View(categoryfromdb);
        }
        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully...";
            return RedirectToAction("Index");
        }
    }
}
