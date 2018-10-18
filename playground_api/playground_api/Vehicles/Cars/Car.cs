using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.CustomEnumerator
{
    public class Car
    {
        public string Name { get; set; } = "";

        public DateTime ModelYear { get; set; } = DateTime.MinValue;

        public Car(string carName = "", DateTime? modelYear = null)
        {
            Name = carName;
            ModelYear = modelYear ?? DateTime.MinValue;
        }
    }
}
