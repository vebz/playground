using System;
using System.Collections.Generic;
using System.Text;

using playground_api.Interfaces;
using playground_api.Interfaces.Draw;

namespace playground_api
{
    public class ShapesDemo
    {
        public ShapesDemo()
        {
        }

        public static void DemoInteface()
        {
            IPointy pointy = null;

            Point newPoint = new Point(10, 20);
            Rectangle newRect = new Rectangle("newRect", 20, 30);

            pointy = newPoint as IPointy;

            if(null != pointy)
                pointy.Description();
            
            pointy = newRect as IPointy;
            if (null != pointy)
                pointy.Description();
        }

        public static void DemoExplicitInterface()
        {
            Rectangle rectangle = new Rectangle("Rectangle With Explicit Inteface Implementation", 10, 30);
            IDraw3D draw = rectangle as IDraw3D;

            if(draw != null)
            {
                draw.Draw();
            }
            IDrawHologram drawHolo = rectangle as IDrawHologram;
            if(drawHolo != null)
            {
                drawHolo.Draw();
            }
        }
    } // ShapesDemo
}
