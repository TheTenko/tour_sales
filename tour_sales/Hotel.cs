using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_sales
{
    public class Hotel
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // "Отель" или "Мотель"
        public int Stars { get; set; }   // от 3 до 5
        public int Nights { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Type}, ★{Stars}) — {Nights} ночей — {Price}$";
        }
    }
}
