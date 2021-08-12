using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Method
{
    class Manager: Employee
    {
        public Manager(string name, string company) : base(name, company)
        {

        }
        public override void Display()
        {
            Console.WriteLine($"манагер {Name} в {Company}");
        }
    }
}
