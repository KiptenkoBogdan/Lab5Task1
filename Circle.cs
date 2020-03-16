using System;

namespace Lab5Task1
{
    class Circle : Figure
    {
        protected double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            double S;
            S = Math.PI * Math.Pow(this.r, 2);
            return S;
        }
        public override double Perimeter()
        {
            double P;
            P = 2 * Math.PI * this.r;
            return P;
        }
        public override void Get_Info()
        {
            Console.WriteLine("\tCircle");
            Console.WriteLine("S = {0}", this.Area());
            Console.WriteLine("Circle length = {0}", this.Perimeter());
        }
    }
}
