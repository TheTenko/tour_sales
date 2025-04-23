using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_sales
{
    public static class HotelGenerator
    {
        private static readonly string[] HotelNames = {
        "Grand Plaza", "Sunset Resort", "OceanView Inn", "Mountain Lodge", "Royal Stay",
        "City Motel", "Budget Stay", "Skyline Hotel", "Lakefront Inn", "Cozy Nights"
    };

        private static readonly string[] Types = { "Отель", "Мотель" };

        private static readonly Random rnd = new Random();

        public static List<Hotel> Generate(string city)
        {
            var result = new List<Hotel>();

            for (int i = 0; i < 10; i++)
            {
                result.Add(new Hotel
                {
                    City = city,
                    Name = HotelNames[rnd.Next(HotelNames.Length)],
                    Type = Types[rnd.Next(Types.Length)],
                    Stars = rnd.Next(3, 6), // 3, 4 или 5
                    Nights = rnd.Next(2, 8),
                    Price = rnd.Next(80, 300)
                });
            }

            return result;
        }
    }
}
