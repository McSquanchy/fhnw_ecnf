using System.Collections.Generic;

namespace PersonAdminLib
{
    public class PersonRegister
    {
        private List<Person> personList;

        public PersonRegister() 
        {
            personList = new List<Person>();
            personList.Add(new Person("Hans", "Müller"));
            personList.Add(new Person("Erich", "Weber"));
            personList.Add(new Person("Jean", "Ziegler"));
        }

 
        public int Count { get { return personList.Count; } }

        public Person this[int index]
        {
            get { return this.personList[index]; }
        }
    }
}
