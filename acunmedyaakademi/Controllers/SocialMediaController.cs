using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using acunmedyaakademi.Models;

namespace acunmedyaakademi.Controllers
{
    public class SocialMediaController : Controller
    {
     
       DbPortfolyoEntities1 db = new DbPortfolyoEntities1();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia p)
        {
            db.TblSocialMedia.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia p)
        {
            var value = db.TblSocialMedia.Find(p.SocialMediaId);
            value.İconUrl = p.İconUrl;
            value.İconimage = p.İconimage;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}