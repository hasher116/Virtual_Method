using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Method
{
    class Employee: Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base (name)
        {
            Company = company;
        }
        public override void Display() // можно добавить sealed и тогда в manager не переопределиться метод
        {
            base.Display();
            Console.WriteLine($"Name = {Name}, Company = {Company}");
        }
    }
}
