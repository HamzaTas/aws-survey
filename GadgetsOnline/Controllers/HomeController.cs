using GadgetsOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace GadgetsOnline.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        //Inventory inventory;
        public ActionResult Index()
        {
            //inventory = new Inventory();
            return View();
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