using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace APIClientDemo.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            var client=new HttpClient();
            var respone =  client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?id=281133&appid=b1b15e88fa797225412429c1c50c122a").Result;

            return Content(respone);
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