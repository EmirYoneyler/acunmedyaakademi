using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using acunmedyaakademi.Models;

namespace AcunMedyaAkademiPortfollo.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolyoEntities1 db = new DbPortfolyoEntities1();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblCategory.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.skillAvgValue = db.TblSkill.Average(X => X.Value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault(); //veritabanında metot eksik gerek de yok bence uğraşma :) 
            //ViewBag.mvcCategoryProjectCount = db.TblCategory.Where(x => x.CategoryId == 4).Count();


            ViewBag.GetLastSkillTitle = db.TblSkill.OrderByDescending(s => s.SkillId).Select(s => s.Title).FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.TblProject.Count(p => p.ProjectName == "Flutter");
            ViewBag.hobbyCount = db.TblHobby.Count();
            ViewBag.serviceCount = db.TblService.Count();

            ViewBag.highestSkillScore = db.TblSkill.Max(s => s.Value);
            ViewBag.lowestSkillScore = db.TblSkill.Min(s => s.Value);
            ViewBag.ProjectName = db.TblProject.OrderByDescending(p => p.ProjectId).Select(p => p.ProjectName).FirstOrDefault();

            return View();
        }
    }
}
