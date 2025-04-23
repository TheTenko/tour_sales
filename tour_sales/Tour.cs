using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_sales
{
    public class Tour
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{From} → {To}, {StartDate:dd.MM} – {EndDate:dd.MM}, {Price}$";
        }
    }
}
