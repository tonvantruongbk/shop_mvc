using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
    }
}