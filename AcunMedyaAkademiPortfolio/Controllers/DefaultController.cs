using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;
namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkills()
        {
            var values = db.TblSkills.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var projectcount = db.TblProject.ToList().Count();
            var testimonialcount = db.TblTestimonial.ToList().Count();
            var servicecount = db.TblService.ToList().Count();
            var skillcount = db.TblSkills.ToList().Count();
            ViewBag.ProjectCount = projectcount;
            ViewBag.TestimonialCount = testimonialcount;
            ViewBag.ServiceCount = servicecount;
            ViewBag.SkillCount = skillcount;
            return PartialView();
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialHobby()
        {
            var values = db.TblHobby.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAddress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact y)
        {
            if (ModelState.IsValid)
            {
                db.TblContact.Add(y);
                db.SaveChanges();

                ViewBag.RedirectUrl = Url.Action("Index", "Default");
            }
            return PartialView();
        }
        public PartialViewResult PartialSocialmedia()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter1()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter2()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
    }
}