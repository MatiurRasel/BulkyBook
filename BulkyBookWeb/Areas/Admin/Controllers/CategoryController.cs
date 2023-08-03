using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _unitOfWork.Category.GetAll();

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
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
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
            //var categoryfromdb = _db.Categories.Find(id);
            //var categoryfromDbFirst = _db.Categories.SingleOrDefault(c => c.Id == id);
            var categoryFromDbSingle = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);
            if (categoryFromDbSingle == null)
            {
                return NotFound();
            }


            return View(categoryFromDbSingle);
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
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
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
            //var categoryfromdb = _db.Categories.Find(id);
            //var categoryfromDbFirst = _db.Categories.SingleOrDefault(c => c.Id == id);
            var categoryFromDbSingle = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);

            if (categoryFromDbSingle == null)
            {
                return NotFound();
            }


            return View(categoryFromDbSingle);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully...";
            return RedirectToAction("Index");
        }
    }
}
