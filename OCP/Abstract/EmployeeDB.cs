using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Abstract
{
    public abstract class EmployeeDB
    {
        public EmployeeDB()
        {
            Employees.Add(new Employee
            {
                BornDate = new DateTime(1986, 7, 10),
                Salary = 1000,
                Name = "Mohammad Shoorabi",
            });
        }
        public HashSet<Employee> Employees = new HashSet<Employee>();

        public abstract Employee Select();
    }
}
