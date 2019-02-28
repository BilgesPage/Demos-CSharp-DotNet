using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App012_IClonable
{
    class Point : ICloneable
    {
        public Point()
        {
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public object Clone()
        {
            return new Point { X = this.X, Y = this.Y };
        }
    }
}
