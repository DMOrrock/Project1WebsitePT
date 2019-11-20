using Project1WebsitePT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1WebsitePT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us to schedule an appointment!";

            return View();
        }

        public static List<string> exercises = new List<String>() { "Calf Stretch", "Hamstring Stretch", "Wall Push Up" };
        public ActionResult Exercise()
        {
            ViewBag.Exercises = exercises;
            ViewBag.Message = "your Excercise Page";

            return View();
        }
        public ActionResult ExerciseInfo(string exName)
        {

            Exercise displayExcercise = new Exercise
            {
                Name = exName,
                MuscleGroup = "Gastrocnemius Lateral Head",
                RepNumber = 3,
                Time = "30 Seconds",
                Graphic = "https://www.healthlinkbc.ca/sites/default/libraries/healthwise/media/medical/hw/hwkb17_077.jpg",
                SimilarEX1 = "calf raises",
                SimilarEX2 = "Standing IT Band Stretch"
            }; //rather have a static array of exercises where you and find the item. using the name passed in. 

            return View(displayExcercise);
        }
        public ActionResult LogIn()
        {
            ViewBag.Message = "your Excercise Page";

            return View();
        }
    }
}