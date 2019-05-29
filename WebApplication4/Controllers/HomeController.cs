using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Calculator()
        {
            return View();
        }

        public ActionResult Result(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "Plus": ViewBag.Result = num1 + num2;
                    break;
                case "Minus":
                    ViewBag.Result = num1 - num2; 
                    break;
                case "Multiply":
                    ViewBag.Result = num1 * num2;
                    break;
                case "Divide":
                    ViewBag.Result = num1 / num2;
                    break;
            }
            ViewBag.Operation = operation;   
            return View();
        }

    }
}