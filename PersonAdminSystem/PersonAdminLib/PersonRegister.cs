using System;
using System.Collections.Generic;
using System.IO;

namespace PersonAdminLib
{
    public class PersonRegister
    {
        private List<Person> personList;
        private IEnumerable<Person> Persons { get { return personList; } }

        public delegate void PersonAddedHandler(object source, PersonEventArgs args);

        public event PersonAddedHandler PersonAddedHandlerEvent;

        public PersonRegister() 
        {
            personList = new List<Person>();
        }

 
        public int Count { get { return personList.Count; } }


        public Person this[int index]
        {
            get { return this.personList[index]; }
        }

        public int ReadPersonsFromFile(string file)
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string s in lines)
            {
                string[] name = s.Split("\t");
                if (name.Length != 2)
                {
                    throw new Exception(string.Format("Error Reading files from file %s!", file));
                }
                Add(new Person(name[0], name[1]));
            }
            return lines.Length;
        }

        public void Sort(Comparison<Person> comparison)
        {
            personList.Sort(comparison);
        }

        public void PrintPersons()
        {
            foreach (var p in Persons)
                Console.WriteLine($"{p.Surname}, {p.Firstname}");
        }

        int Add(Person newPerson)
        {
            personList.Add(newPerson);
            PersonAddedHandlerEvent?.Invoke(this, new PersonEventArgs(newPerson));
            return personList.Count;
        }

        public Person FindPerson(Predicate<Person> match)
        {
            return personList.Find(match);
        }
    }
}
