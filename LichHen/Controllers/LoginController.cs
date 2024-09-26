using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LichHen.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult DangKy()
        {
            return View();
        }
    }
}