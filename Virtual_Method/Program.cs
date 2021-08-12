using System;

namespace Virtual_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill");
            p1.Display();

            Employee p2 = new Employee("Tom", "Microsoft");
            p2.Display();

            Manager p3 = new Manager("Vasya", "Discovery");
            p3.Display();

            LongCredit credit = new LongCredit();
            credit.Sum = 6000;
            Console.WriteLine(credit.Sum);
            credit.Sum = 500;
            Console.WriteLine(credit.Sum);
            credit.Sum = 7000;
            Console.WriteLine(credit.Sum);

        }
    }
}
