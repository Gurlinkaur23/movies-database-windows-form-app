using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDatabaseWindowsFormApp.Entities
{
    public class Rating
    {
        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Movie")]
        public int MovieID { get; set; }
        public float RatingValue { get; set; }
        public int Timestamp { get; set; }

        // Navigation properties
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
    }
}
