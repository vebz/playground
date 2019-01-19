using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqPlayground
{
    static public class LinqLibrary
    {
        public static void NonGenericCollectionDemo()
        {
            List<Car> cars = new List<Car>()
            {
                new Car{PetName = "Geeta Q7", Make = "Audi", Model = "Q7", Speed = 220.0f},
                new Car{PetName = "Geeta A3", Make = "Audi", Model = "A3", Speed = 160.0f},
                new Car{PetName = "Vebz 7 Series", Make = "BMW", Model = "7 Series", Speed = 240.0f},
                new Car{PetName = "My 5 Series", Make = "BMW", Model = "5 Series", Speed = 180.0f},
                new Car{PetName = "My 3 Series", Make = "BMW", Model = "3 Series", Speed = 160.0f},
                new Car{PetName = "Golfi", Make = "Golf", Model = "2012", Speed = 160.0f},
                new Car{PetName = "Corolla", Make = "Toyota", Model = "Corolla", Speed = 110.0f},
                new Car{PetName = "Merz", Make = "Mercedes", Model = "E Class", Speed = 240.0f}
            };

            var fastCars = cars.Where(fcars => fcars.Speed >= 240.0f);
            foreach(var car in fastCars)
            {
                Console.WriteLine(car.PetName);
            }
        }

        public static void QueryArrayString()
        {
            string[] gameNames = { "Doom Odessey", "Uncharted", "God of War", "Gears of War" };

            //IEnumerable<string> gamesWithSpaces = from g in gameNames
            //                                      where g.Contains(" ")
            //                                      orderby g
            //                                      select g;

            IEnumerable<string> gamesWithSpaces = gameNames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

            foreach (string currGame in gamesWithSpaces)
            {
                Console.WriteLine("Curr Iter game : " + currGame);
            }
        }

        public static void DemoSubsetNamesAndDescription()
        {
            List<ProductInfo> products = ProductInfo.GetDemoData();

            var nameDesc = products.Select(product => new { product.Name, product.Description });

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void DemoOrderedList()
        {
            List<ProductInfo> products = ProductInfo.GetDemoData();
            var orderedProducts = products.OrderBy(p => p.Name);

            foreach (var item in orderedProducts)
            {
                Console.WriteLine(item.ToString());
            }

        }


    }
}
