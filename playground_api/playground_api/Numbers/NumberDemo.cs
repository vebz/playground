using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Numbers
{
    public class NumberDemo
    {
        public static void Demo()
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 1,2,3,45,456,657,567,432});
            List<int> evenNumbers = numbers.FindAll(IsEven);
            PrintNumbers("Even numbers", evenNumbers);
        }

        public static void LamdaDemo()
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 1, 2, 3, 45, 456, 657, 567, 432 });
            
            List<int> evenNumbers = numbers.FindAll((int i) => (i % 2) == 0);
            List<int> allNumbers = numbers.FindAll((int i) => true);
            List<int> noNumbers = numbers.FindAll((int i) => false);

            PrintNumbers("Even numbers", evenNumbers);
            PrintNumbers("All numbers", allNumbers);
            PrintNumbers("No numbers", noNumbers);
        }

        public static void LamdaDelegateDemo()
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 1, 2, 3, 45, 456, 657, 567, 432 });

            List<int> evenNumbers = numbers.FindAll(delegate (int i)
            {
                return (i % 2) == 0;
            });

            PrintNumbers("Even numbers", evenNumbers);
        }

        public static void PrintNumbers(string message, List<int> numberList)
        {
            Console.WriteLine(message);
            foreach (int number in numberList)
            {
                Console.WriteLine(number.ToString());
            }
        }

        public static bool IsEven(int i)
        {
            return (i % 2) == 0;
        }
    }
}
