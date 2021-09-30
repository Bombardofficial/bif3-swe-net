using System;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    public class Rectangle : Shape, IShapeComposition
    {
        private int _sideA, _sideB;
        private int factor = 2;
        public Rectangle(int x, int y, int a, int b) : base(x, y)
        {
            _sideA = a;
            _sideB = b;
        }

        public double getArea()
        {
            return _sideA * _sideB;
        }

        public double GetPerimeter()
        {
            return (factor * _sideA) + (factor * _sideB);
        }
        public voide PrintShapeType()
        {
            Console.WriteLine("I'm a Rectangle.")
        }
    }




}
