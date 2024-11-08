using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LABIKS9.Controllers
{
    public class lab9Controller : Controller
    {
        // GET: lab9
        public ActionResult FirstViewMethod()
        {
            List<string> animals = GetAnimalsList();
            return View(animals);
        }

        public ActionResult SecondViewMethod()
        {
            return View(GetAnimalsList().OrderBy(x => x).ToList());
        }

       public ActionResult ThirdViewMethod()
        {
            return View(GetAnimalsList().OrderBy(x => x).ToList());
        }
        public List<string> GetAnimalsList()
        {
            List<string> animals = new List<string>();
            animals.Add("Doter");
            animals.Add("Donkey Kong");
            animals.Add("Petuh");
            animals.Add("KFC Chicken strips");
            animals.Add("Pig");
            animals.Add("Kaban");
            animals.Add("Zayats");
            animals.Add("Grinch");
            animals.Add("Crazy Rooster");
            animals.Add("Crackhead");
            animals.Add("Myravei");

            return animals;
        }
    }
}