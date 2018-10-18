using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    class HarleyDavidson : Motorcycle
    {
        const int MAX_SPEED = 100; //mph

        int currSpeed = 0;
        int CurrSpeed
        {
            get => currSpeed;

            set
            {
                if(value < MAX_SPEED)
                {
                    currSpeed = value;
                }
            }
        }

        public HarleyDavidson(string bikeName, int intensity, string modelNumber) 
            : base(bikeName, intensity)
        {
            this.HarleyModelNo = modelNumber;
        }

        public string HarleyModelNo
        {

            get => default;
            set
            {
            }
        }

        public void SpeedUpBy(int speed)
        {
            if(speed > MAX_SPEED)
            {
                throw new Exception($"{nickName} has overheated");
            }
            else
            {
                currSpeed += speed;
            }
        }
    }
}
