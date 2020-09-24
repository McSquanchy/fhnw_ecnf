using System;
using PersonAdminLib;

namespace PersonAdminSystem
{
    class PersonAdminApplication
    {
        static void Main(string[] args)
        {

            //Person p1 = new Person("Hans", "Meier");
            //Person p2 = new Person("Fritz", "Loser");
            //Console.WriteLine($"Person 1: {p1.Firstname} {p1.Surname}");
            //Console.WriteLine($"Person 2: {p2.Firstname} {p2.Surname}");
            var personRegister = new PersonRegister();

            Console.WriteLine("Person: {0} {1}",
                personRegister[personRegister.Count - 1].Firstname,
                personRegister[personRegister.Count - 1].Surname);
            Console.WriteLine($"Person: {personRegister[0].Firstname} {personRegister[0].Surname}");
            Console.ReadKey();
        }
    }
}
