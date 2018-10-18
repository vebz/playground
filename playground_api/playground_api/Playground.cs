using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace playground_api
{
    class Playground
    {
        public enum Days : Byte
        {
            Monday = 0,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public void LinqQueryOverInts()
        {
            int[] numbers = { 1, 3, 10, 15, 20 };

            var subset = from i in numbers
                         where i < 10
                         select i;

            foreach(var number in subset)
            {
                Console.WriteLine(number);
            }
        }

        public void JaggedMultiDimensionalArrays()
        {
            Console.WriteLine("=> Jagged Multi dimensional array");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int[][] jaggedArray = new int[5][];
            Console.WriteLine(jaggedArray.Length);

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[i + 7];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void CalculateAverage(out double average, params double[] values)
        {
            Console.WriteLine(@"=> Calculating Average");
            double sum = 0;

            for (int currValueIndex = 0; currValueIndex < values.Length; currValueIndex++)
            {
                sum += values[currValueIndex];
            }

            average = sum / values.Length;
        }

        public void GreetOnDay(Days currDay)
        {
            switch(currDay)
            {
                case Days.Monday:
                    Console.WriteLine(@"Monday");
                break;

                default:
                    Console.WriteLine("None");
                    break;
            }
        }
    }
}
