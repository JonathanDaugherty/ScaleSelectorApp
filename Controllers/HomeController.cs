using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaleSelectorApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

           public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(); 
        } 

        public static string RandomKey(int textLength)
        {
            string[] keys = { "A", "A#", "Bb", "B", "C", "C#", "Db", "D", "D#", "Eb", "E", "F", "F#", "Gb", "G", "G#", "Ab" };
            Random r = new Random();
            int index = r.Next(keys.Length);

            return keys[index];
        }
    }
}