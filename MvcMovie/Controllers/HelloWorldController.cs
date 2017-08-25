using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie
{
    public class HelloWorldController : Controller
    {
       // GET: /Default1/
               
        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
      
        public ActionResult Welcome(string name, int NumTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes =  NumTimes;
            return View();
        }

    }
}
