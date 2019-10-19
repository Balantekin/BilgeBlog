using BilgeBlog.Areas.Admin.Models.DTO;
using BilgeBlog.Models.ORM.Entity;
using BilgeBlog.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BilgeBlog.Controllers
{
    public class SiteHomeController : SiteBaseController
    {
        // GET: SiteHome
        public ActionResult Index()
        {
            List<SiteBlogPostVM> model = db.Blogs.Where(x => x.IsDeleted == false).OrderByDescending(x => x.AddDate).Select(x => new SiteBlogPostVM()
            {
                Title = x.Title,
                Category = x.Category.CategoryName,
                AddTime=x.AddDate,
                ID=x.ID
                


            }).ToList();

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            
            
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactVM model)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact();
                contact.SenderName = model.SenderName;
                contact.Email = model.Email;
                contact.PhoneNumber = model.PhoneNumber;
                contact.Message = model.Message;

                db.Contacts.Add(contact);
                db.SaveChanges();


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                //yeni email adresi alınıp şifre değiştirilecek
                client.Credentials = new NetworkCredential("balantekinbugra@gmail.com", "20493260Aq");
                client.EnableSsl = true;
                MailMessage message = new MailMessage(model.Email,"balantekinbugra@gmail.com");
                message.Body = model.Message;
                message.Subject = model.SenderName + model.PhoneNumber;

                client.Send(message);

                ViewBag.MailDurum = 1;

                return View();
            }
            else
            {
                ViewBag.MailDurum = 2;
                return View();
            }

         
        }



        
    }
}