using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api.Shapes.Classes
{
    class RectangleFloat
    {
        public float Width { get; set; }

        public float Height { get; set; }

        public RectangleFloat(float width = 0.0f, float height = 0.0f)
        {
            Width = width;
            Height = height;
        }

        public static explicit operator RectangleFloat(float sameLength)
        {
            RectangleFloat rectangleFloat = new RectangleFloat(sameLength, sameLength);
            return rectangleFloat;
        }

        public override string ToString()
        {
            return $"Width : {Width}, Height : {Height}";
        }

        public static void CastDemo()
        {
            RectangleFloat square = (RectangleFloat)10.0f;
            Console.WriteLine(square.ToString());
        }
    }
}



