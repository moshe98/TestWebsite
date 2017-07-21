using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Services;

namespace TestWebsite.Controllers
{
    public class HomeController : Controller
    {
        IHomeService _service;

        public HomeController(IHomeService service)
        {
            _service = service;
        }

      
       
        public ActionResult Index()
        {
            return View();
        }

    }
}
