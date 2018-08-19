using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Abstract
{
    public class EmployeeManagerRepo : EmployeeDB
    {
        public override Employee Select()
        {
            var emp = Employees.FirstOrDefault();
            return new Employee
            {
                BornDate = emp.BornDate,
                Name = emp.Name,
                Salary = 0,
            };
        }
    }
}
