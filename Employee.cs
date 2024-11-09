using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Generic_collections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFemale { get; set; }
        public int Salary { get; set; }

        public Employee(int Id, string Name, bool IsFemale, int Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.IsFemale = IsFemale;
            this.Salary = Salary;
        }
    }
}
