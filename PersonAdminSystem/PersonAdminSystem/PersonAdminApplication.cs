using PersonAdminLib;
using System;
using System.Reflection;

namespace PersonAdminSystem
{
    class PersonAdminApplication
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Hans", "Meier");
            Person p2 = new Person("Fritz", "Loser");
            Console.WriteLine($"Person 1: {p1.Firstname} {p1.Surname}");
            Console.WriteLine($"Person 2: {p2.Firstname} {p2.Surname}");
            Console.ReadKey();
        }
    }
}
