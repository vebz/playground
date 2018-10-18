using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    class Tuples
    {
        //public (string, int, int) member
        //{
        //    get
        //    {
        //        return member;
        //    }
        //}

        public float PointX = 0;
        public float PointY = 0;

        public Tuples()
        {
            //member = newMember;
        }

        public Tuples((string, int, int) newMember)
        {
            //member = newMember;
        }

        public void PlayWithTuples()
        {
            (int, int, int) values = (1, 2, 3);
            (string first, string second, string third) valuesWithNames = ("a", "b", "c");
            Console.WriteLine(values);
            Console.WriteLine(@"Values with names - First : {0}, Second : {1}, Third : {2}",valuesWithNames.first, valuesWithNames.second, valuesWithNames.third);
        }

        public (string first, string middle, string last) SplitNames(string fullName)
        {
            string[] splitNames = fullName.Split(' ');
            return (splitNames[0], splitNames[1], splitNames[2]);
        }

        public (float, float) Deconstruct() => (PointX, PointY);
    }
}
