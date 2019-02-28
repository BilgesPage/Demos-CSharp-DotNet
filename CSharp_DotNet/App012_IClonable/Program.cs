using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App012_IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 6);
            Point p2 = (Point)p1.Clone();

            Console.WriteLine($"P1=> x:{p1.X}, y:{p1.Y}");
            Console.WriteLine($"P2=> x:{p2.X}, y:{p2.Y}");

            Console.ReadLine();
        }
    }
}
