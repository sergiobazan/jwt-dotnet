using Jwt.Models;

namespace Jwt.Constants
{
    public class EmployeeConstants
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee() {FirstName="Juan", LastName="Perez", Email="juan.perez@gmail.com"},
            new Employee() {FirstName="Diego", LastName="Milito", Email="diego.milito@gmail.com"}
        };
    }
}
