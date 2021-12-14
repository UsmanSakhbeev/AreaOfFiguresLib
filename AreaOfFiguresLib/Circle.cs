using System;

namespace AreaOfFiguresLib
{
    public class Circle : BaseFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be more than zero");
            Radius = radius;
        }

        override public double Calculate()
        {
            return Result = 2 * 3.14f * Radius;
        }
    }
}
