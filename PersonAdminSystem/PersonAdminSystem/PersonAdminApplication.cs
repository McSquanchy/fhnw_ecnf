using System;
using System.IO;
using PersonAdminLib;

namespace PersonAdminSystem
{
    class PersonAdminApplication
    {
        static void Main(string[] args)
        {
            var personRegister = new PersonRegister();
            personRegister.PersonAddedHandlerEvent += ConsoleHandler;
            personRegister.PersonAddedHandlerEvent += PrintHandler;
            personRegister.ReadPersonsFromFile("Resources/Persons.txt");
            personRegister.Sort(CompareBySurname);
            personRegister.Sort(CompareByFirstname);
            personRegister.PrintPersons();

            Console.WriteLine("First Match:");
            Person p = personRegister.FindPerson(ContainsA);
            Console.WriteLine($"{p.Firstname} {p.Surname}");
            Console.ReadKey();
        }

        static int CompareByFirstname(Person p1, Person p2)
        {
            return p1.Firstname.CompareTo(p2.Firstname);
        }

        static int CompareBySurname(Person p1, Person p2)
        {
            return p1.Surname.CompareTo(p2.Surname);
        }

        static void ConsoleHandler(object source, PersonEventArgs args)
        {
            Console.WriteLine($"{args.Person.Surname} - {args.Person.Firstname}");
        }

        static void PrintHandler(object source, PersonEventArgs args)
        {
            File.AppendAllLines(@"C:\temp\logfile.txt", new[] {$"{DateTime.Now:dd-MM-yyyy HH:mm:ss} | {args.Person.Surname}, {args.Person.Firstname}"});
        }

        static bool ContainsA(Person p)
        {
            return p.Firstname.Contains("a") && p.Surname.Contains("a");
        }
    }
}
