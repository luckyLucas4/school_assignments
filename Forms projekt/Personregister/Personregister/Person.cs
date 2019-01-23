using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Person : IComparable<Person>
    {
        public string namn;
        public string ålder;

        public int CompareTo(Person other)
        {

            return this.namn.CompareTo(other.namn);
        }
    }
}
