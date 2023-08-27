using Jwt.Models;

namespace Jwt.Constants
{
    public class CountryConstants
    {
        public static List<Country> Countries = new List<Country>()
        {
            new Country() {Name = "Peru"},
            new Country() {Name = "Argentina"},
            new Country() {Name = "Colombia"}
        };
    }
}
