using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Moovie.Models
{
    public class Film
    {
        public string FilmName { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
    }
}