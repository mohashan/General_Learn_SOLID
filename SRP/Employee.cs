﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Employee
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public DateTime BornDate { get; set; }

        //private HashSet<Employee> employees = new HashSet<Employee>();
        //public Employee Select()
        //{
        //    return employees.FirstOrDefault();
        //}
        //public bool Insert(Employee employee)
        //{
        //    try
        //    {
        //        employees.Add(employee);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //}
    }
}
