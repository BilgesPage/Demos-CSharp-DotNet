using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App017_OperatorOverloading
{
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator + (Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);

        public static bool operator ==(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
            { return true; }
            else return false;
        }

        public static bool operator !=(Point a, Point b)
        {
            if (a.X != b.X || a.Y != b.Y)
            { return true; }
            else return false;
        }
    }
}
