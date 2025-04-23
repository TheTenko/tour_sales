using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_sales
{
    public static class TourGenerator
    {
        public static List<Tour> Generate(string from, string to, DateTime start, DateTime end, int count = 10)
        {
            var rnd = new Random();
            var tours = new List<Tour>();

            for (int i = 0; i < count; i++)
            {
                var range = (end - start).Days;
                if (range < 3) break;

                var randomStartOffset = rnd.Next(0, Math.Max(1, range - 3));
                var tourStart = start.AddDays(randomStartOffset);
                var tourEnd = tourStart.AddDays(rnd.Next(3, 10));

                if (tourEnd > end) continue;

                tours.Add(new Tour
                {
                    From = from,
                    To = to,
                    StartDate = tourStart,
                    EndDate = tourEnd,
                    Price = rnd.Next(300, 1500)
                });
            }

            return tours;
        }
    }

}
