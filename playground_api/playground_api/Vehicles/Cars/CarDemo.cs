using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Vehicles
{
    public class CarDemo
    {
        public void DemoEvents()
        {
            Car newCar = new Car("Bugs Bunny", DateTime.Now);
            newCar.EngineExploded += OnNewCarEngineExploded;
            newCar.EngineAboutToBlow += OnNewCarEngineAboutToBlow;
            
            for(int i = 0; i < 100.0f; i++)
            {
                if (newCar.Status == CarStatus.Dead)
                {
                    break;
                }
                newCar.Accelerate(20.0f);
            }

            newCar.Accelerate(20.0f);

            Console.WriteLine($"Car Status is {newCar.Status}");
        }

        private void OnNewCarEngineAboutToBlow(object sender, CarEventArgs e)
        {
            if(sender is Car car)
            {
                Console.WriteLine("Critical message from {0} : {1}", car.Name, e.msg);
            }
        }

        private void OnNewCarEngineExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine("Engine explosion => {0} says: {1}", sender, e.msg);
        }

        private void OnNewCarAboutToBlow(string message)
        {
            Console.WriteLine("OnAboutToBlow");
            Console.WriteLine(message);
        }

        private void OnNewCarExploded(string message)
        {
            Console.WriteLine("OnExploded");
            Console.WriteLine(message);
            //throw new NotImplementedException();
        }

        public void OnExploded(string message)
        {
            Console.WriteLine("OnExploded");
            Console.WriteLine(message);
        }

        public void OnAboutToBlow(string message)
        {
            Console.WriteLine("OnAboutToBlow");
            Console.WriteLine(message);
        }
    }

}
