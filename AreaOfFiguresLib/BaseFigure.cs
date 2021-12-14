using System;

namespace AreaOfFiguresLib
{
    public abstract class BaseFigure
    {
        public double Result { get; set; }
        public abstract double Calculate();
    }
}
