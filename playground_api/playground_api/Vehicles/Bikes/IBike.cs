using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Vehicles
{
    public interface IBike
    {
        DateTime ModelYear { get; set; }
        string BikeName { get; set; }
        double Price { get; set; }
    }
}
