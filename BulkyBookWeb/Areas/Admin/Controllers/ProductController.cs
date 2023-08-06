using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<CoverType> objList = _unitOfWork.CoverType.GetAll();

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
        public IActionResult Create(CoverType obj)
        {
            var coverTypeList = _unitOfWork.CoverType.GetAll();
            List<string> nameList = coverTypeList.Select(x => x.Name).ToList();
            if (nameList.Contains(obj.Name))
            {
                //ModelState.AddModelError("CustomError", "The Display order cannot exactly match the name.");
                ModelState.AddModelError("name", "This is a duplicate cover type.");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Cover Type created successfully...";
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
            var coverTypeFromDbSingle = _unitOfWork.CoverType.GetFirstOrDefault(c => c.Id == id);
            if (coverTypeFromDbSingle == null)
            {
                return NotFound();
            }
            return View(coverTypeFromDbSingle);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CoverType obj)
        {
            var coverTypeList = _unitOfWork.CoverType.GetAll();
            List<string> nameList = coverTypeList.Select(x => x.Name).ToList();
            if (nameList.Contains(obj.Name))
            {
                //ModelState.AddModelError("CustomError", "The Display order cannot exactly match the name.");
                ModelState.AddModelError("name", "This is a duplicate cover type.");
            }
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Cover Type updated successfully...";
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
            var coverTypeFromDbSingle = _unitOfWork.CoverType.GetFirstOrDefault(c => c.Id == id);

            if (coverTypeFromDbSingle == null)
            {
                return NotFound();
            }


            return View(coverTypeFromDbSingle);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.CoverType.GetFirstOrDefault(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.CoverType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Cover Type deleted successfully...";
            return RedirectToAction("Index");
        }
    }
}
