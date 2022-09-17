using System;
namespace MindBoxLibrary
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double GetSquare()
        {
            //Use Geron formula
            double polyPerimetr = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt
                (polyPerimetr * (polyPerimetr - _sideA) * (polyPerimetr - _sideB) * (polyPerimetr - _sideC));
        }
        public bool IsRectangular()
        {
            var poweredSideA = (int)Math.Pow(_sideA,2);
            var poweredSideB = (int)Math.Pow(_sideB,2);
            var poweredSideC = (int)Math.Pow(_sideC,2);

            // Check zero sides
            if (poweredSideA == 0 ||
                poweredSideB == 0 ||
                poweredSideC == 0)
            {
                return false;
            }

            if (poweredSideC == poweredSideA + poweredSideB ||
                poweredSideB == poweredSideA + poweredSideC ||
                poweredSideA == poweredSideB + poweredSideC)
            {
                return true;
            }

            return false;
        }
    }
}