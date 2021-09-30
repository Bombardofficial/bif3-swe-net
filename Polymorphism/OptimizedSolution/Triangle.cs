using System;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Triangle : Shape, IShapeComposition
    {
        private double SiteA { get; set; }
        private double SiteB { get; set; }
        private double SiteC { get; set; }
        
        public Triangle(int x, int y, double SiteA, double SiteB, double SiteC) : base(x, y)
        {
            this.SiteA = SiteA;
            this.SiteB = SiteB;
            this.SiteC = SiteC;
        }
        
        public double GetPerimeter()
        {
            return SiteA + SiteB + SiteC;
        }
       
        public double GetArea()
        {
            double Heron = (SiteA + SiteB + SiteC) / 2;
            double Area = Math.Sqrt(Heron * (Heron - SiteA) * (Heron - SiteB) * (Heron - SiteC));
            return Area;
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a Triangle");
        }
    }
}