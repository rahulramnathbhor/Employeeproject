using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeproject
{
    internal class Employee
    {
        int id;
        string name;
        float salary;
        public void AssignValue()
        {
            id = 1;
            name = "Rahul";
            salary = 1000;
        }
            public string DisplayValue()
            {
            return $"Employee detail:{id}/{name}/{salary}";
            }
        

    }
}
