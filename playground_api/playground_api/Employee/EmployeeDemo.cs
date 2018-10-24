using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Employee
{
    public class EmployeeDemo
    {
        public static void DemoSortedSet()
        {
            Person vebz = new Person { firstName = "Vebz", lastName = "Panchal", age = 28 };
            Person parul = new Person { firstName = "Parul", lastName = "Panchal", age = 32 };
            Person usha = new Person { firstName = "Usha", lastName = "Panchal", age = 45 };
            Person ramesh = new Person { firstName = "Ramesh", lastName = "Panchal", age = 52 };

            int one = 1;
            int two = 2;


            SortedSet<Person> people = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {firstName = "Vebz", lastName = "Panchal", age = 28},
                new Person {firstName = "Parul", lastName = "Panchal", age = 32},
                new Person {firstName = "Usha", lastName = "Panchal", age = 45},
                new Person {firstName = "Ramesh", lastName = "Panchal", age = 52}
            };

            foreach(Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
