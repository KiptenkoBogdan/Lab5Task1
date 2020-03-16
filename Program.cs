using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] F = new Figure[3];

            F[0] = new Rectangle(3, 5);
            F[1] = new Triangle(3, 5, 7, 2.5);
            F[2] = new Circle(6);

            for (int i = 0; i < 3; i++)
                F[i].Get_Info();

            Console.ReadKey();
        }
    }
}
