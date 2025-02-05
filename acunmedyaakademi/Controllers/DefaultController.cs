using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using acunmedyaakademi.Models;
namespace acunmedyaakademi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbPortfolyoEntities1 db = new DbPortfolyoEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
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
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
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
        public PartialViewResult PartialProjects()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonials()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var skillcount = db.TblSkill.ToList().Count();
            var testimonialcount = db.TblTestimonial.ToList().Count();
            var projectcount = db.TblProject.ToList().Count();
            var servicecount = db.TblService.ToList().Count();
            ViewBag.SkillCount = skillcount;
            ViewBag.TestimonialCount = testimonialcount;
            ViewBag.ProjectCount = projectcount;
            ViewBag.ServiceCount = servicecount;
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact p)
        {
            db.TblContact.Add(p);
            db.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialAdress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAlttaraf()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult Enson()
        {
            return PartialView();
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
       
        }
    }
