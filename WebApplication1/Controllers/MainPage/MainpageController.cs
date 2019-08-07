using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers.MainPage
{
    public class MainpageController : Controller
    {
        
        public ActionResult AnaSayfa()
        {
            return View();
        }
    }
}