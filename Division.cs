using System;
using System.Collections.Generic;

namespace Laboration2
{
    public class Division : AbstractDivision, IDivision
    {
        private new string Name;
        private new List<Employee> Employees;
        public string GetName()
        {
            return this.Name;
        }
        public List<Employee> GetEmployees()
        {
            return this.Employees;
        }
    }
}
