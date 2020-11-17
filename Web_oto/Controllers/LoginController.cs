using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_oto.Models;
using System.Data.SqlClient;
namespace Web_oto.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        // GET: Account
        SqlCommand com = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataReader dr;
        webotoEntities db = new webotoEntities();
        public ActionResult Login()
        {
            return View();
        }
        //void connectionString()
        //{
        //    con.ConnectionString = "data source=DESKTOP-G6K7MET\\SQLEXPRESS; database=test; integrated security= SSPI;";
        //}
        [HttpPost]
        public ActionResult Login(DSKH log)
        {
            var user = db.DSKHs.Where(x => x.Username == log.Username && x.Password == log.Password).Count();
            if (user >0)
            {
                return View("~/Views/Home/Home.cshtml");
            }
            //connectionString();
            //con.Open();
            //com.Connection = con;
            //com.CommandText = "select * from dbo.accounts where username='" + acc.Username + "' and password='" + acc.Password + "'";
            //dr = com.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (acc.Username == "ngoclam")
            //    {
            //        con.Close();

            //        return View("~/Views/Home/Home.cshtml");
            //    }
            //    else
            //    {
            //        con.Close();
            //        //return View("~/Views/Home/Index.cshtml");
            //    }
            //}
            return View("~/Views/Register/Register.cshtml");
        }
    }
}