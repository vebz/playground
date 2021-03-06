﻿using System;
using System.Collections.Generic;
using System.Text;
using playground_api.Interfaces.Draw;

namespace playground_api
{ 
    struct Rectangle<T> : IPointy<T>, IDraw3D, IDrawHologram
    {

        public byte Points => TOTAL_RECT_POINTS;

        public Rectangle(string newRectInfo, T PointX, T PointY)
        {
            rectInfo = new ShapeInfo(newRectInfo);
            X = PointX;
            Y = PointY;
        }

        public void Message()
        {
            Console.WriteLine(@"RectInfo {0}", rectInfo.InfoString);
        }

        public byte GetNumberOfPoints()
        {
            return TOTAL_RECT_POINTS;
        }

        public void Description()
        {

            Console.WriteLine($"Rect {rectInfo.InfoString} ");
        }

        void IDraw3D.Draw()
        {
            Console.WriteLine("Drawing from Draw 3D");
        }

        void IDrawHologram.Draw()
        {
            Console.WriteLine("Drawing from Hologram");
        }

        public ShapeInfo rectInfo;
        public T X;
        public T Y;
        const byte TOTAL_RECT_POINTS = 4;
    }
}
