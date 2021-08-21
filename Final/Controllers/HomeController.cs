using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        /*
        public HomeController()
        {

        }
        private ApplicationDbContext _application;
        public HomeController(ApplicationDbContext application)
        { 
            _application = application;
        }
        */
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        /*
       
        public ActionResult About1()
        {
            return View(_application.Users.ToList());
        }
       */
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}