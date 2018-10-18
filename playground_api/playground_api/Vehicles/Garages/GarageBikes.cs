using playground_api.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace playground_api.CustomEnumerator
{
    class GarageBikes : IEnumerable, IGarageBikes
    {
        private List<IBike> bikes = new List<IBike>();
        public List<IBike> Bikes
        {
            get
            {
                return bikes;
            }

            set
            {
                if (value != null && value != bikes)
                {
                    foreach(IBike newBike in value)
                    {
                        if(!bikes.Contains(newBike))
                        {
                            bikes.Add(newBike);
                        }
                    }
                }
            }
        }

        public GarageBikes(List<IBike> newBikes = null)
        {
            bikes = newBikes ?? new List<IBike>();
        }

        public void AddBikeToGarage(IBike bike)
        {
            try
            {
                Bikes.Add(bike);
            }
            catch (ArgumentNullException nullException)
            {
                ConsoleColor prevColour = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Null bikes Exceptopm.");
                Console.WriteLine($"{nullException.Message}");
                Console.WriteLine($"{nullException.TargetSite}");
                Console.WriteLine($"{nullException.StackTrace}");
                Console.ForegroundColor = prevColour;
            }
        }

        public IEnumerator GetEnumerator()
        {
            yield return bikes[0];
            yield return bikes[1];
            yield return bikes[2];
            yield return bikes[3];
            //foreach(Bikes bike in bikes)
            //{
            //    yield return bike;
            //}
        }

        public IBike HireBike(string bikeName)
        {
            throw new NotImplementedException();
        }
    }
}
