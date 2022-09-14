using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee project = new Employee();
            project.AssignValue();
            Console.WriteLine(project.DisplayValue());
        }
    }
}
