using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndManager
{
    internal class Employee : IPerson
    {
        public Employee() :this("Employee") { }

        public Employee(string name) 
        {
            Name= name; 
        }
        public string Name { get; set; }
    }
}
