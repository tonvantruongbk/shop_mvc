﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        // GET: Admin/DanhMuc
        public ActionResult DanhMuc()
        {
            return View();
        }
    }
}