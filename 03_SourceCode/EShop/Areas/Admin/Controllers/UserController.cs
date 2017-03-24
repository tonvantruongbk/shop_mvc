using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/ThanhVien
        public ActionResult ThanhVien()
        {
            return View();
        }
    }
}