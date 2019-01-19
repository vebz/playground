using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinqLibrary.QueryArrayString();
            LinqLibrary.NonGenericCollectionDemo();
            LinqLibrary.DemoSubsetNamesAndDescription();
            LinqLibrary.DemoOrderedList();

            Console.ReadKey();
        }
    }
}
