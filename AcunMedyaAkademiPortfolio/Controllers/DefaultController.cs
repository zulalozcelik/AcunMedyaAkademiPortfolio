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
            var skillcount = db.TblSkills.ToList().Count();
            ViewBag.SkillCount = skillcount;
            return PartialView();
        }
    }
}