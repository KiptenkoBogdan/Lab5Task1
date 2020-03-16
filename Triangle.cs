using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task1
{
    class Triangle : Figure
    {
        protected double a;
        protected double b;
        protected double c;
        protected double h_a;
        public Triangle(double a, double b, double c, double h_a)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h_a = h_a;
        }
        public override double Area()
        {
            double S;
            S = (this.a * this.h_a)/2;
            return S;
        }
        public override double Perimeter()
        {
            double P;
            P = this.a + this.b + this.c;
            return P;
        }
        public override void Get_Info()
        {
            Console.WriteLine("\tTriangle");
            Console.WriteLine("S = {0}", this.Area());
            Console.WriteLine("P = {0}", this.Perimeter());
        }
    }
}
