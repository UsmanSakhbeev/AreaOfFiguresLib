using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFiguresLib
{
    public class TriangleFigure : IFigure
    {
        private readonly List<float> _sides = new List<float>(3);

        public TriangleFigure(float a, float b, float c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Triangle doesn't exist");

            _sides.Add(a);
            _sides.Add(b);
            _sides.Add(c);
            _sides.Sort();

            if (_sides[0] + _sides[1] < _sides[2])
                throw new ArgumentException("Triangle doesn't exist");            
        }

        public float Area
        {
            get
            {
                var p = (_sides[0] + _sides[1] + _sides[2]) / 2;
                return (float)Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
            }
        }

        public bool IsRight => Math.Pow(_sides[2], 2) == Math.Pow(_sides[1], 2) + Math.Pow(_sides[0], 2);
    }
}
