using System;

namespace MindBoxLibrary
{ 
    public abstract class Shape
    {
        public abstract double GetSquare();
    }

    public class Circle : Shape
    {
        protected double _radius;
        
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetSquare()
        {
            return Math.Pow(this._radius, 2) * Math.PI;
        }
    }

    public class Triangle : Shape
    {
        protected double _sideA;
        protected double _sideB;
        protected double _sideC;

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
            // Checking rectangular via Pythagoras' theory
            if (Math.Pow(this._sideA, 2) > (Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2)) ||
                (Math.Pow(_sideB, 2) > (Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2)) || 
                 (Math.Pow(_sideC, 2) > (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2)))))
            {
                return true;
            }
                    
            return false;
        }
    }
}