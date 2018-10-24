using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Employee
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return 
                (x.age > y.age)? 1 :  // // x is older than y
                (x.age < y.age)? -1 : // x is younger than y 
                0; // Same Age
        }
    }
}
