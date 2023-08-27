using Jwt.Models;

namespace Jwt.Constants
{
    public class ProductConstants
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name="Coca Cola", Description="Bebida con gas"},
            new Product() {Name="Agua Cielo", Description="Agua mineral de 2L"}
        };
    }
}
