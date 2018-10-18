using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    class Motorcycle
    {
        public int intensity;
        public string driverName;

        public string nickName { get; set; } = "";

        public string RegisteredName { get; set; } = "NeedRegisteredName";

        public string WhoAmI { get; set; } = "Noone";

        public Motorcycle() : this("", 0)
        {

        }

        public Motorcycle(int intensity) : this("", intensity)
        {

        }

        public Motorcycle(string name, int intensity)
        {
            this.nickName = name;
            this.intensity = intensity;
        }
    }
}
