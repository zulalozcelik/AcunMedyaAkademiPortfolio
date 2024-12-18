using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class SkillsController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult SkillsList()
        {
            var values = db.TblSkills.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(TblSkills p)
        {
            db.TblSkills.Add(p);
            db.SaveChanges();
            return RedirectToAction("SkillsList");
        }
        public ActionResult DeleteSkill(int id) 
        {
            var value=db.TblSkills.Find(id);
            db.TblSkills.Remove(value); 
            db.SaveChanges();
            return RedirectToAction("SkillsList");
        }
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkills.Find(id);
            return View(value);
        }
    }
}