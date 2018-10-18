using System;
using playground_api.CustomEnumerator;

namespace playground_api
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Playgound Pro C# .Net Core API";
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            ShowEnvironmentDetails();
            ShowNumberFormat();
            ShowDefaultDeclarations();
            TryFromStringWithTryParse();
            Playground playground = new Playground();
            playground.LinqQueryOverInts();
            playground.JaggedMultiDimensionalArrays();

            playground.CalculateAverage(out double average, 4.0, 3.0, 5.0);

            Console.WriteLine(@"Average {0}", average);

            Playground.Days currDay = Playground.Days.Monday;
            playground.GreetOnDay(currDay);

            Rectangle newRect = new Rectangle(@"Original Rectangle Info", 1, 2);
            Console.WriteLine(@"Original Rect Message");
            newRect.Message();
            Rectangle copyRect = newRect;
            copyRect.rectInfo.InfoString = @"Modified Rectangle Info";
            Console.WriteLine(@"Copy Rect Message");
            copyRect.Message();
            Console.WriteLine(@"Original Rect Message post modification");
            newRect.Message();

            Console.WriteLine(@"Tuple members");
            Tuples tuples = new Tuples();
            tuples.PlayWithTuples();

            Console.WriteLine(@"Split Members");
            Tuples splitNames = new Tuples();

            var(first, _, last) = splitNames.SplitNames("Vaibhav Ramesh Panchal");
            Console.WriteLine($"{first} {last}");

            Point deconstructedTuple = new Point(30.0f, 40.0f);
            var (xPos, yPos, color) = deconstructedTuple.Deconstruct();
            Console.WriteLine($"xPos : {xPos}, yPos : {yPos}, color : {color}");


            // Exception DemoInteface
            try
            {
                HarleyDavidson harleyDavidson = new HarleyDavidson("harley", 1, "HR1001");
                for (int i = 0; i < 5000; i++)
                {
                    harleyDavidson.SpeedUpBy(i);
                }

            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("===Speed Exception===");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("===Speed Exception===");
            }

            // Interface
            //ShapesDemo.DemoInteface();
            ShapesDemo.DemoExplicitInterface();

            //EnumDemo.Demo();
            //EnumDemo.DemoCustomerEnumerator();
            EnumDemo.DemoYield();
            Console.ReadKey();

            return 0;
        }

        private static void ShowEnvironmentDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine("Environment .Net Version: {0}", Environment.Version);
        }

        private static void ShowNumberFormat()
        {
            Console.WriteLine("The numebr formats:");
            Console.WriteLine("c format: {0:c}", 999);
            Console.WriteLine("c format: {0:d9}", 999);
        }

        private static void ShowDefaultDeclarations()
        {
            Console.WriteLine("Data declarations");
            int myInt = default;
            Console.WriteLine("myInt default declaration {0}", myInt);

            System.Int32 systemInt = default;
            Console.WriteLine("systemInt default declaration {0}", systemInt);
        }

        private static void TryFromStringWithTryParse()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=> Data trype parsing with TryParse:");

            if(bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double: ", value);
            }
        }
    }
}
