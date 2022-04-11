using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TA_ASP_Kecskek.Models;

namespace TA_ASP_Kecskek.Controllers
{

    public class HomeController : Controller
    {
        public static Random rnd = new Random();

        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);   
        }

        public ActionResult Index()
        {
            var kecskek = _context.Kecskek.ToList();
            var atadandoKecskek = new List<Kecske>();

            return View(kecskek);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}