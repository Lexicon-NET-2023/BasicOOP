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

        public virtual void Do()
        {
            Console.WriteLine("Person do");
        }
    }

    internal class Employee  : Person
    {
        public int Salary { get; set; }

        public   void Doing()
        {
            // base.Do();
            Console.WriteLine("Admin do");
        }

    } 
    
    internal class Admin  : Employee
    {
        public string? Department { get; set; }

        public override void Do()
        {
           // base.Do();
            Console.WriteLine("Admin do");
        }
    }
}
