using System;
using System.Linq;

namespace OCP.Abstract
{
    public class EmployeeRepo : EmployeeDB
    {
        public override Employee Select()
        {
            return Employees.FirstOrDefault();
        }
    }
}
