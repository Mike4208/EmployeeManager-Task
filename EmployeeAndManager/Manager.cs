using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndManager
{
    internal class Manager : IPerson
    {
        public Manager() :this("Manager") { }
        public Manager(string name) 
        {
            Name= name;
        }

        public string Name { get; set; }
    }
}
