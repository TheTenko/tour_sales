using System.Text.Json.Serialization;

namespace tour_sales
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Nickname { get; set; }
    }
}
