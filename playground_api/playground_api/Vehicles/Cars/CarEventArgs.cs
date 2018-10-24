using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Vehicles
{
    public class CarEventArgs : EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string message)
        {
            msg = message;
        }
    }
}
