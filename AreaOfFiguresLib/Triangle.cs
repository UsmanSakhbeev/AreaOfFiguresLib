using System;

namespace AreaOfFiguresLib
{
    public class Triangle : BaseFigure
    {
        public double Hypotenuse { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public double P { get; set; }
        public bool IsTriangleRight { get; set; }
        public Triangle(double hypotenuse, double secondSide, double thirdSide)
        {
            if (hypotenuse <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Triangle side must be positive");
            Hypotenuse = hypotenuse;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        public override double Calculate()
        {
            P = (Hypotenuse + SecondSide + ThirdSide) / 2;
            Result = Math.Sqrt(P * (P - Hypotenuse) * (P - SecondSide) * (P - ThirdSide));
            return Result;
        }
        public bool IsTriangleRightChecking()
        {
            if (Math.Pow(Hypotenuse, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
                IsTriangleRight = true;
            else IsTriangleRight = false;
            return IsTriangleRight;
        }
    }
}
