using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace playground_api.Employee
{
    public class PersonCollection : IEnumerable
    {
        ArrayList people;
        Dictionary<string, Person> namedPeople;

        public PersonCollection()
        {
            people = new ArrayList();
            namedPeople = new Dictionary<string, Person>();
        }

        public Person this[int index]
        {
            get => (Person)people[index];

            set => people.Insert(index, value);
        }

        public Person this[string name]
        {
            get => namedPeople[name];

            set => namedPeople.Add(name, value);
        }

        public void AddNewPerson(Person person)
        {
            try
            {
                people.Add(person);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unable to add new person in Person");
                Console.WriteLine("Exception : {0}", e.Message);
                Console.WriteLine("Function Name : {0}", e.TargetSite.Name);
                Console.WriteLine("Call Stack : {0}", e.StackTrace);
            }
        }

        public void AddNamedPerson(String name, Person person)
        {
            namedPeople.Add(name, person);
        }

        private Random randomAge = new Random();
        public void AddRandomPerson()
        {
            string randomFirstName = RandomString(5);
            string randomLastName = RandomString(5);
            uint age = (uint)randomAge.Next(0, 30);
            Person person = new Person(randomFirstName, randomLastName, age);
            people.Add(person);
        }

        public void AddRandomNamedPerson()
        {
            string randomName = RandomString(5);
            Person person = new Person();
            namedPeople.Add(randomName, person);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Person person in people)
            {
                yield return person;
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void PersonCollectionDemo()
        {
            PersonCollection people = new PersonCollection();
            const int MAX_RANDOM_PEOPLE = 5;

            for(int i = 0; i < MAX_RANDOM_PEOPLE; i++)
            {
                people.AddRandomPerson();
                Console.WriteLine($"Random Person generated at {i}");
            }

            for (int i = 0; i < MAX_RANDOM_PEOPLE; i++)
            {
                Console.WriteLine($"Random Person generated at {i} - {people[i].ToString()}");
            }
        }
    }
}
