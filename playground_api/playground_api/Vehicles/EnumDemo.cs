using playground_api.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace playground_api.CustomEnumerator
{
    public class EnumDemo
    {
        public static void Demo()
        {
            Car[] cars =
            {
                new Car("Mini Sports", DateTime.Today),
                new Car("Audi A3", DateTime.Today),
                new Car("BMW 5 Series", DateTime.Today)
            };

            GarageCars garage = new GarageCars(cars);
        }

        public static void DemoCustomerEnumerator()
        {
            Car[] cars =
            {
                new Car("Mini Sports", DateTime.Today),
                new Car("Audi A3", DateTime.Today),
                new Car("BMW 5 Series", DateTime.Today)
            };
            GarageCars garage = new GarageCars(cars);

            foreach(Car car in garage)
            {
                Console.WriteLine($"Car model make is : {car.ModelYear.ToShortDateString()}");
            }

        }

        public static void DemoYield()
        {
            List<IBike> newBikes = new List<IBike>();
            newBikes.Add(new Bikes("Harley ", DateTime.Today));
            newBikes.Add(new Bikes("Hero Honda", DateTime.Today));
            newBikes.Add(new Bikes("Red Indian", DateTime.Today));

            GarageBikes garageBikes = new GarageBikes(newBikes);
            IEnumerator enumerator = garageBikes.GetEnumerator();
            enumerator.MoveNext();
        }
    }
}
