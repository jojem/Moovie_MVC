using Moovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moovie.Controllers
{
    public class HomeController : Controller
    {
        private Film[] films = new Film[]
        {
            new Film
            {
                FilmName = "Earthlings",
                Year = 2005,
                Genre = "Documentary | Horror",
                Country = "USA"
            },
            new Film
            {
                FilmName = "Before the Flood",
                Year = 2016,
                Genre = "Documentary | News",
                Country = "USA"
            },
            new Film
            {
                FilmName = "Freedom Writers",
                Year = 2007,
                Genre = "Biography | Crime | Drama",
                Country = "Germany | USA"
            },
            new Film
            {
                FilmName = "Green Book",
                Year = 2018,
                Genre = "Biography | Comedy | Drama | Music",
                Country = "USA"
            },
            new Film
            {
                FilmName = "A Beautiful Mind ",
                Year = 2001,
                Genre = "Biography | Drama",
                Country = "USA"
            },
            new Film
            {
                FilmName = "Whiplash",
                Year = 2014,
                Genre = "Drama | Music",
                Country = "USA"
            },
            new Film
            {
                FilmName = "The Truman Show",
                Year = 1998,
                Genre = "Comedy | Drama | Sci-Fi",
                Country = "USA"
            },
            new Film
            {
                FilmName = "The Professor and the Madman",
                Year = 2019,
                Genre = "Biography | Drama | Mystery | Thriller",
                Country = "Ireland"
            },
            new Film
            {
                FilmName = "Detachment",
                Year = 2011,
                Genre = "Drama",
                Country = "USA"
            },
            new Film
            {
                FilmName = "Dead poets society",
                Year = 1989,
                Genre = "Comedy | Drama",
                Country = "USA"
            }
        };
        



        // GET: Home
        public ActionResult Index(int afterYear = 0)
        {
            ViewBag.Title = "Moovie";
            return View(films.Where(x => x.Year >= afterYear).ToArray());
        }

       

        public ActionResult ErrorAction()
        {
            return View("Error message blabla");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }
    }
}