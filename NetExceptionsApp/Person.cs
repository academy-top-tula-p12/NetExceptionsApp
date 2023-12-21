using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExceptionsApp
{
    internal class Person
    {
        public string? Name { get; set; }
        int age;
        public int Age {
            get => age;
            set
            {
                if (age > 0)
                    age = value;
                else
                    throw new PersonAgeException("Age must be more zero!");
            }
        }
    }

    class PersonAgeException : Exception
    {
        public PersonAgeException(string message) : base(message) { }
    }
}
