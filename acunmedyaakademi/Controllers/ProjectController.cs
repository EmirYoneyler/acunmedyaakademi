using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using acunmedyaakademi.Models;

namespace acunmedyaakademi.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DbPortfolyoEntities1 db = new DbPortfolyoEntities1();
        public ActionResult Index()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.TblProject.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var value = db.TblProject.Find(p.ProjectId);
            value.ProjectName = p.ProjectName;
            value.ProjectImageUrl = p.ProjectImageUrl;
            value.ProjectCategory = p.ProjectCategory;
            //value. = p.ProjectGitLink;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}