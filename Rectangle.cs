using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task1
{
    class Rectangle: Figure
    {
        protected double a;
        protected double b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Area()
        {
            double S;
            S = this.a * this.b;
            return S;
        }
        public override double Perimeter()
        {
            double P;
            P = this.a + this.a + this.b + this.b;
            return P;
        }
        public override void Get_Info()
        {
            Console.WriteLine("\tRectangle");
            Console.WriteLine("S = {0}", this.Area());
            Console.WriteLine("P = {0}", this.Perimeter());
        }
    }
}
