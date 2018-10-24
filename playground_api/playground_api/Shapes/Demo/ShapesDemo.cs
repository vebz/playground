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
            IPointy<int> pointy = null;

            Point<int> newPoint = new Point<int>(10, 20);
            Rectangle<int> newRect = new Rectangle<int>("newRect", 20, 30);

            pointy = newPoint as IPointy<int>;

            if(null != pointy)
                pointy.Description();
            
            pointy = newRect as IPointy<int>;
            if (null != pointy)
                pointy.Description();
        }

        public static void DemoExplicitInterface()
        {
            Rectangle<int> rectangle = new Rectangle<int>("Rectangle With Explicit Inteface Implementation", 10, 30);
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
