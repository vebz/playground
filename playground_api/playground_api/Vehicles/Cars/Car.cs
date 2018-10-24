using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Vehicles
{
    public enum CarStatus
    {
        Dead,
        Alive
    };

    public class Car
    {
        public string Name { get; set; } = "";

        public DateTime ModelYear { get; set; } = DateTime.MinValue;

        public event EventHandler<CarEventArgs> EngineExploded;
        public event EventHandler<CarEventArgs> EngineAboutToBlow;

        public CarStatus Status { get; set; } = CarStatus.Alive;

        const double MAX_SPEED = 100.0f;

        private float currSpeed = 0.0f;
        public float CurrSpeed {

            get => currSpeed;

            set
            {
                if (value < 0.0f)
                {
                    currSpeed = 0.0f;
                } 
                else
                {
                    currSpeed = value;
                }
            }
        }

        public Car(string carName = "", DateTime? modelYear = null)
        {
            Name = carName;
            ModelYear = modelYear ?? DateTime.MinValue;
        }

        public void Accelerate(float delta)
        {
            if(CarStatus.Dead == Status)
            {
                EngineExploded?.Invoke(this, new CarEventArgs("Sorry, this engine has exploded"));
            }
            else if(CarStatus.Alive == Status)
            {
                CurrSpeed += delta;
                Console.WriteLine($"Car speed has been increased to {CurrSpeed}");

                if((MAX_SPEED - CurrSpeed) <= 10.0f)
                {
                    EngineAboutToBlow?.Invoke(this, new CarEventArgs("Careful, engine is about to blow"));
                }

                if(MAX_SPEED - CurrSpeed <= 1.0f)
                {
                    Status = CarStatus.Dead;

                }
            }
        }
    }
}
