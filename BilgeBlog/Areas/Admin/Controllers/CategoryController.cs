using BilgeBlog.Areas.Admin.Models.DTO;
using BilgeBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category

        public ActionResult Index()
        {
            List<CategoryVM> model = db.Categories.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new CategoryVM()
            {
                Name = x.CategoryName,
                Description = x.Description,
                ID = x.ID
            }).ToList();

            return View(model);
        }

        //Admin/Category/AddCategory çağrıldığında çalışacak
        //ilk sayfa açılışı - get
        public ActionResult AddCategory()
        {
            return View();
        }

        //Formu post ettiğimizde aşağıya düşecek
        [HttpPost]
        public ActionResult AddCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.CategoryName = model.Name;
                category.Description = model.Description;

                db.Categories.Add(category);
                db.SaveChanges();
                ViewBag.islemDurum = 1;

                return View();
            }
            else
            {
                ViewBag.islemDurum = 2;
                return View();
            }
        }

        public ActionResult UpdateCategory(int id)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            CategoryVM model = new CategoryVM();
            model.Name = category.CategoryName;
            model.Description = category.Description;

            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateCategory(CategoryVM model)
        {
            if(ModelState.IsValid)
            {
                Category category = db.Categories.FirstOrDefault(x => x.ID == model.ID);
                category.CategoryName = model.Name;
                category.Description = model.Description;

                db.SaveChanges();
                ViewBag.islemDurum = 1;

                return View();
            }
            else
            {
                ViewBag.islemDurum = 2;
                return View();
            }

        }

        public JsonResult DeleteCategory(int id)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.IsDeleted = true;
            category.DeleteDate = DateTime.Now;
            db.SaveChanges();

            return Json("");
        }
    }
}
      