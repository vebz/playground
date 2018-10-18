using playground_api.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.CustomEnumerator
{
    public class Bikes : IBike
    {
        DateTime modelYear = DateTime.MinValue;
        string bikeName;
        double bikePrice;

        DateTime IBike.ModelYear { get => default; set => modelYear = value; }
        public string BikeName { get => bikeName; set => bikeName = value; }
        public double Price { get => bikePrice; set => bikePrice = value; }

        public Bikes(string bikeName = "", DateTime? bikeModelYear = null, double price = double.MinValue)
        {
            BikeName = bikeName;
            modelYear = bikeModelYear ?? DateTime.MinValue;
            Price = price;
        }
    }
}
