using System;

namespace AreaOfFiguresLib
{
    public class CircleFigure : IFigure
    {
        private readonly float _radius;

        public CircleFigure(float radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be more than zero");
            _radius = radius;            
        }

        public float Area => (float)Math.PI * _radius * _radius;
    }
}
