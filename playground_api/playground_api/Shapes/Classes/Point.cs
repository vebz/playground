using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    enum PointColor {LightBlue, BloodRed, Gold}

    struct Point : IPointy
    {
        public float xPos;
        public float yPos;
        public PointColor color { get; set; }

        const byte TOTAL_POINTs = 2;

        public byte Points => TOTAL_POINTs;
        public byte GetNumberOfPoints() => TOTAL_POINTs;

        public Point(float x = 0, float y = 0, PointColor newColor = PointColor.Gold)
        {
            xPos = x;
            yPos = y;
            color = newColor;
        }

        public (float X, float Y, PointColor color) Deconstruct() => (xPos, yPos, color);

        public void Description()
        {

            Console.WriteLine($"Point {xPos} and {yPos}");
        }
    }
}
