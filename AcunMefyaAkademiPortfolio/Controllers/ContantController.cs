﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMefyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1();

        [HttpGet]
        public ActionResult ContactList()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }

        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult SendMessage(TblContact c)
        {
            c.SendDate = DateTime.Now;
            c.IsRead = false;
            db.TblContact.Add(c);
            int v = db.SaveChanges();
            return Redirect("/Default/Index#contact");
        }

        public ActionResult OpenContact(int id)
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.TblContact.Find(id);
            db.TblContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}