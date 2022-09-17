using System;
namespace MindBoxLibrary
{
    public class Circle : Shape
    {
        protected int _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }

        public override double GetSquare()
        {
            if (_radius < 0)
            {
                return -1;
            }
            var result = Math.Pow(_radius, 2) * Math.PI;
            return Math.Round(result);
        }
    }
}