using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cinema_management
{
    public class Movie
    {
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public string Genre { get; set; }
        public string AgeRating { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Image Poster { get; set; }
    }
}
