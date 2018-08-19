using System.Linq;
namespace OCP.Extension
{
    public static class EmployeeManagerExtension
    {
        public static Employee ManagerSelect(this EmployeeDB employeeDB)
        {
            var emp = employeeDB.Select();
            return new Employee
            {
                BornDate = emp.BornDate,
                Name = emp.Name,
                Salary = 0,
            };
        }
    }
}
