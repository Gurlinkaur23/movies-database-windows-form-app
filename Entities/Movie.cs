using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDatabaseWindowsFormApp.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string IMDbLink { get; set; }
        public bool Action { get; set; }
        public bool Adventure { get; set; }
        public bool Comedy { get; set; }
        public bool Drama { get; set; }
        public bool Romance { get; set; }
        public bool Thriller { get; set; }
        public bool ScienceFiction { get; set; }
        public bool Animation { get; set; }
        public bool Fantasy { get; set; }
        public bool Horror { get; set; }
        public bool Musical { get; set; }
        public bool Mystery { get; set; }
        public bool Documentary { get; set; }
        public bool War { get; set; }
        public bool Crime { get; set; }
        public bool Western { get; set; }
        public bool FilmNoir { get; set; }
        public bool Childrens { get; set; }
        public bool Other { get; set; }

        // Navigation property
        public ICollection<Rating> Ratings { get; set; }
    }
}
