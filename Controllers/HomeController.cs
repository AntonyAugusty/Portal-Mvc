using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Configuration;

using Newtonsoft.Json;

using Project.Web.Domain.Entities;
using Project.Web.Configuration.Manager.Common;
using Project.Web.Configuration.Manager.Register;

namespace Portal_Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Users users = new Users();
            ModelState.AddModelError("CustomError", "");
            return View(users);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Users usersModel)
        {
            if (ModelState.IsValid)
            {
                var dt =    Register.FetchObject(usersModel);
                Users _users = new Users();
                var flgSuccess = false;
                if (dt.Tables[0].Rows.Count > 0)
                {
                    flgSuccess = true;

                    _users.Name = Convert.ToString(dt.Tables[0].Rows[0]["Name"]);
                }

                if (flgSuccess)
                {
                    //string userData = JsonConvert.SerializeObject(_users);
                    //FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                    //         1,
                    //         _users.Name,
                    //         DateTime.Now,
                    //         DateTime.Now.AddMinutes(60),
                    //         false,
                    //         userData);

                    //string encryptTicket = FormsAuthentication.Encrypt(authTicket);
                    //HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket);
                    //Response.Cookies.Add(httpCookie);


                    //HttpCookie namedCookie = new HttpCookie("lang");
                    //namedCookie.Value = _users.Name;
                    //namedCookie.Expires = DateTime.Now.AddDays(1);
                    //Response.Cookies.Add(namedCookie);

                    return RedirectToAction("Registration");
                    //return View("Btc");
                    //return Redirect("/");
                }
                else
                {
                    ViewBag.Success = "0";
                    //    ViewBag.GroupId = Convert.ToString(ConfigurationSettings.AppSettings["DefualtGrupId"]);

                    ModelState.AddModelError("CustomError", "Incorrect username and/or password");
                    //return Redirect("/");
                    return View("Index");
                }
            }
            else
            {
                ModelState.AddModelError("CustomError", "Incorrect username and/or password");
                return RedirectToAction("Index");
            }
        }

        public ActionResult Registration()
        {
            Users users = new Users();
            var dt = Common.FetchCountry();

            List<Masters> countryList = new List<Masters>();
            countryList = (from System.Data.DataRow dr in dt.Tables[0].Rows
                           select new Masters()
                           {
                               Id = Convert.ToInt32(dr["Id"]),
                               Name = dr["Name"].ToString()
                           }).ToList();

            ViewBag.Country = new SelectList(countryList, "Id", "Name");

            return View("Registration", users);
            //return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(Users usersModel)
        {
            var dt = Common.FetchCountry();
            List<Masters> countryList = new List<Masters>();
            countryList = (from System.Data.DataRow dr in dt.Tables[0].Rows
                           select new Masters()
                           {
                               Id = Convert.ToInt32(dr["Id"]),
                               Name = dr["Name"].ToString()
                           }).ToList();

            ViewBag.Country = new SelectList(countryList, "Id", "Name");
            return View();
        }

        public ActionResult Registration1()
        {
            var dt = Common.FetchCountry();
            List<Masters> countryList = new List<Masters>();
            countryList = (from System.Data.DataRow dr in dt.Tables[0].Rows
                           select new Masters()
                           {
                               Id = Convert.ToInt32(dr["Id"]),
                               Name = dr["Name"].ToString()
                           }).ToList();

            ViewBag.Country = new SelectList(countryList, "Id", "Name");
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Registration1(Users usersModel)
        {
            usersModel.IsActive = true;
            usersModel.Flag = 1;
            usersModel.PaidStatus = 0;

            var retVal = Register.IUDAction(usersModel);

            return View("Btc");
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult Btc(Users usersModel)
        {
            ViewBag.Message = "Your application description page.";

            Users users = new Users();
            return View();
        }

        public ActionResult Btc()
        {
            ViewBag.Message = "Your application description page.";

            Users users = new Users();
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
    }
}