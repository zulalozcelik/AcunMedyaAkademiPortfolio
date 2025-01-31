using AcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ContactController : Controller
    {
     
            DbPortfolioEntities db = new DbPortfolioEntities();
            public ActionResult Index()
            {
                var values = db.TblContact.ToList();
                return View(values);
            }
            [HttpGet]
            public ActionResult CreateContact()
            {
                return View();
            }
            [HttpPost]
            public ActionResult CreateContact(TblContact p)
            {
                db.TblContact.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            public ActionResult DeleteContact(int id)
            {
                var value = db.TblContact.Find(id);
                db.TblContact.Remove(value);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            [HttpGet]
            public ActionResult UpdateContact(int id)
            {
                var value = db.TblContact.Find(id);
                return View(value);
            }

            [HttpPost]
            public ActionResult UpdateContact(TblContact p)
            {
                var value = db.TblContact.Find(p.ContactId);
                value.Name = p.Name;
                value.Email = p.Email;
                value.Subject = p.Subject;
                value.Description = p.Description;
                value.CreateDate = p.CreateDate;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
    }
}
