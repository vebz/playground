using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace playground_api.Vehicles
{
    interface IGarageBikes
    {
        void AddBikeToGarage(IBike bike);
        IBike HireBike(string bikeName);
    }
}
