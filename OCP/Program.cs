using OCP.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var empDB = new Extension.EmployeeDB();

            var empExt = empDB.ManagerSelect();
            var empExt2 = empDB.Select();

            var empAbsDB = new Abstract.EmployeeRepo();
            var empAbs = empAbsDB.Select();
            var empAbsDB2 = new Abstract.EmployeeManagerRepo();
            var empAbs2 = empAbsDB2.Select();

        }
    }
}
