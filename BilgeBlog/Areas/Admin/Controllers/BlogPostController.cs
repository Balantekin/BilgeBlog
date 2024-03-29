﻿using BilgeBlog.Areas.Admin.Models.DTO;
using BilgeBlog.Areas.Admin.Models.Services.HTMLDataSourceServices;
using BilgeBlog.Models.ORM.Entity;
using BilgeBlog.Models.VM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Areas.Admin.Controllers
{
    public class BlogPostController : BaseController
    {
        public ActionResult Index()
        {
            List<BlogPostVM> model = db.Blogs.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new BlogPostVM()
            {
                Title = x.Title,
                CategoryName=x.Category.CategoryName,
               ID=x.ID
                
                
            }).ToList();

            return View(model);
        }

        public ActionResult AddBlogPost()
        {
            BlogPostVM model = new BlogPostVM();
            model.DropdownCategories = DropDownServices.getDropDownCategories();

            return View(model);
                      

        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddBlogPost(BlogPostVM model)
        {
            BlogPostVM vmodel = new BlogPostVM();
            vmodel.DropdownCategories = DropDownServices.getDropDownCategories();

            if (ModelState.IsValid)
            {
                string fileName = "";
                foreach (string name in Request.Files)
                {
                    model.PostImage = Request.Files[name];
                    string extension = Path.GetExtension(Request.Files[name].FileName);
                    if(extension=="jpg" ||extension=="png"||extension=="jpeg")
                    {
                        string imageNumber = Guid.NewGuid().ToString();
                        fileName = imageNumber + model.PostImage.FileName;
                        model.PostImage.SaveAs(Server.MapPath("~/Areas/Admin/Content/Site/Images/blogpost/" + fileName));
                    }
                   
                        
                }

                Blog blog = new Blog();
                blog.CategoryID = model.CategoryID;
                blog.Title = model.Title;
                blog.Content = model.Content;
                blog.ImagePath = fileName;

                db.Blogs.Add(blog);
                db.SaveChanges();
                ViewBag.islemDurum = 1;

                return View(vmodel);
            }
            else
            {
                ViewBag.islemDurum = 2;

                return View(vmodel);

            }
        }

        public ActionResult UpdateBlogPost(int id)
        {
            Blog blog = db.Blogs.FirstOrDefault(x => x.ID == id);
            BlogPostVM model = new BlogPostVM();
            model.CategoryID = blog.CategoryID;
            model.Title = blog.Title;
            model.Content = blog.Content;
            model.DropdownCategories = DropDownServices.getDropDownCategories();


            return View(model);
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult UpdateBlogPost(BlogPostVM model)
        {
            model.DropdownCategories = DropDownServices.getDropDownCategories();
            if(ModelState.IsValid)
            {
                Blog blog = db.Blogs.FirstOrDefault(x => x.ID == model.ID);
                blog.CategoryID = model.CategoryID;
                blog.Title = model.Title;
                blog.Content = model.Content;

                db.SaveChanges();
                ViewBag.islemDurum = 1;
                return View(model);
            }
            else
            {
                ViewBag.islemDurum = 2;
                return View(model);

            }

        }

        public JsonResult DeleteBlogPost(int id)
        {
            Blog blog = db.Blogs.FirstOrDefault(x => x.ID == id);
            blog.IsDeleted = true;
            blog.DeleteDate = DateTime.Now;
            db.SaveChanges();

            return Json("");
        }

    }
}