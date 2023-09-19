using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{

    internal interface IPerson
    {
        string Name { get; set; }
        void Do();
    }

    internal class Person : IPerson
    {
        public string Name { get; set; } = "";// string.Empty;
        //more props

        public void Do()
        {
            Console.WriteLine("Person d");
        }
    }

    internal class Employee  : Person
    {
        public int Salary { get; set; }
    } 
    
    internal class Admin  : Employee
    {
        public string? Department { get; set; }
    }
}
