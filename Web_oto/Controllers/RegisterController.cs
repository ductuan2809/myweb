using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_oto.Models;
namespace Web_oto.Controllers

{
    public class RegisterController : Controller
    {
        // GET: Register
        webotoEntities db = new webotoEntities();
        public ActionResult Register()
        {
            return View();
        }
      
        //POST: Register
        [HttpPost]

        public ActionResult Register(DSKH _user)
        {

            db.DSKHs.Add(_user);
            db.SaveChanges();
            return View("~/Views/Login/Login.cshtml");
        }
    }
}