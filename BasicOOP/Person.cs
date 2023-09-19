using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    internal class Person
    {
        public string Name { get; set; } = "";// string.Empty;
        //more props
    }

    internal class Employee  : Person
    {
        public int Salary { get; set; }
    } 
    
    internal class Admin  : Employee
    {
        public string Department { get; set; }
    }
}
