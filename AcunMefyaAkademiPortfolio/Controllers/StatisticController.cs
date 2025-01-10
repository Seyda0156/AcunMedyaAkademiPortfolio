using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMefyaAkademiPortfolio.Models;

namespace AcunMefyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1 ();
        public ActionResult Index()
        {
            ViewBag.categorysayisi = db.TblCategory.Count();
            ViewBag.projectsayisi = db.TblProject.Count();
            return View();
        }
    }
}