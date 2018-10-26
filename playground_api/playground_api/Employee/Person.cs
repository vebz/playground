using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Employee
{
    public struct Person
    {
        public string firstName;
        public string lastName;
        public uint age;

        public Person(string firstName = "", string lastName = "", uint age = 0)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} is {age} years old";
        }
    }
}
