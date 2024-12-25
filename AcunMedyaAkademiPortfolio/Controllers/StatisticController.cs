using AcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities db= new DbPortfolioEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.categoryCount= db.TblCategory.Count();
            ViewBag.projectCount= db.TblProject.Count();
            ViewBag.skillCount=db.TblSkills.Count();
            ViewBag.skillAvgValue=db.TblSkills.Average(x=>x.Value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitlee().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory ==4).Count();
            return View();
        }
    }
}