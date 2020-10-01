using System.Runtime.ConstrainedExecution;

namespace PersonAdminLib
{
    public class PersonEventArgs
    {
        public Person Person { get; }

        public PersonEventArgs(Person p)
        {
            Person = p;
        }
    }
}