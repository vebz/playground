using System;
using System.Collections.Generic;
using System.Text;

namespace playground_api
{
    public interface IPointy<T>
    {
        byte GetNumberOfPoints();

        byte Points { get; }

        void Description();
    }
}
