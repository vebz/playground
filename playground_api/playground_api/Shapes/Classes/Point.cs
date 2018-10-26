using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    public enum PointColor {LightBlue, BloodRed, Gold}

    public struct Point<T> : IPointy<T>
    {
        public T xPos;
        public T yPos;

        public PointColor color { get; set; }

        public T X { get => xPos; set => xPos = value; }

        public T Y { get => yPos; set => yPos = value; }

        const byte TOTAL_POINTs = 2;

        public byte Points => TOTAL_POINTs;

        public byte GetNumberOfPoints() => TOTAL_POINTs;

        public Point(T x = default, T y = default, PointColor newColor = PointColor.Gold)
        {
            xPos = x;
            yPos = y;
            color = newColor;
        }

        public void ResetPoint()
        {
            xPos = default;
            yPos = default;
        }

        //public static Point<T> operator +(Point<T> p1, Point<T> p2) => new Point<T>(p1.X + p2.X, p1.Y, p2.Y);

        public (T X, T Y, PointColor color) Deconstruct() => (xPos, yPos, color);

        public override string ToString() => $"[{xPos}, {yPos}]";

        public void Description()
        {
            Console.WriteLine($"Point {xPos} and {yPos}");
        }
    }
}
