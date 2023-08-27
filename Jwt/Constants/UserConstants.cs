using Jwt.Models;

namespace Jwt.Constants
{
    public class UserConstants
    {
        public static List<UserModel> users = new List<UserModel>()
        {
            new UserModel() {Username="sbazan", Password="admin123", Rol="Administrador", EmailAddress="sbazan@rashperu.com", FirstName="Juan", LastName="Perez"},
            new UserModel() {Username="lenrique", Password="admin123", Rol="Vendedor", EmailAddress="lenrique@rashperu.com", FirstName="Luis", LastName="Enrique"}
        };
    }
}
