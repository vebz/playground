using playground_api.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.CustomEnumerator
{
    public class Bikes : IBike
    {
        DateTime modelYear = DateTime.MinValue;

        DateTime IBike.ModelYear { get => default; set => modelYear = value; }
        public string BikeName { get; set; }
        public double Price { get; set; }

        public Bikes(string bikeName = "", DateTime? bikeModelYear = null, double price = double.MinValue)
        {
            BikeName = bikeName;
            modelYear = bikeModelYear ?? DateTime.MinValue;
            Price = price;
        }
    }
}
