using playground_api.CustomEnumerator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    public class GarageCars : IEnumerable
    {
        List<Car> cars = new List<Car>();

        // Cannot garage without any cars. Must have atleast one car. :)
        private GarageCars() { }

        public GarageCars(Car[] garageCars)
        {
            cars.AddRange(garageCars);
            foreach(Car currCar in cars)
            {
                Console.WriteLine($"New Car Added with Name : {currCar.Name}");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }
}
