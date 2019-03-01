using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App017_OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 5);
            Point p2 = new Point(3, 2);

            Console.WriteLine(" p1 and p2 are {0}", p1 == p2 ? "Same point" : "Different points");

            Point p3 = p1 + p2;

            Console.WriteLine($"p3 X: {p3.X}, p3 Y: {p3.Y}");

            Console.ReadLine();
        }
    }
}
