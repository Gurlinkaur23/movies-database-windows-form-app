using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDatabaseWindowsFormApp.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string ZipCode { get; set; }

        // Navigation property
        public ICollection<Rating> Ratings { get; set; }
    }
}
