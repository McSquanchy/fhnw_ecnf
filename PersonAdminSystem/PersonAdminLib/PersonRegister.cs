using System;
using System.Collections.Generic;
using System.IO;

namespace PersonAdminLib
{
    public class PersonRegister
    {
        private List<Person> personList;

        public PersonRegister() 
        {
            personList = new List<Person>();
            int namesAdded = ReadPersonsFromFile("Resources/Persons.txt");
            Console.WriteLine($"Added {namesAdded} names to the register.");
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
                personList.Add(new Person(name[0], name[1]));
            }
            return lines.Length;
        }
    }
}
