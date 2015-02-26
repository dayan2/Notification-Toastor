using Notifications_Toastr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notifications_Toastr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer cus)
        {
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //var cus1 = js.Deserialize<Customer>(cus);

            string str = null;
            if (cus.Name == "jude")
                str = "err";
            else
                str = "Success";
            return Json(str);
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