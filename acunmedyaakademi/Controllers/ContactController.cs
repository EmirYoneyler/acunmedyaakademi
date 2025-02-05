using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using acunmedyaakademi.Models;

namespace acunmedyaakademi.Controllers
{
    public class ContactController : Controller
    {
        DbPortfolyoEntities1 db = new DbPortfolyoEntities1();
        // GET: Contact
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        public ActionResult SendMessage()
        {
            return View();
        }
        public ActionResult MesssageList()
        {
            return View();
        }
        [HttpGet]//BURANIN VİEWLARI EKSİK HALLEDERSİB NASIL YAPIYODUM ONU
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

        public ActionResult DeleteContacts(int id)
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
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

//Müsait misin 2 dakika arayabilirolur