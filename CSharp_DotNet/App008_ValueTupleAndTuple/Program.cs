using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App008_ValueTupleAndTuple
{
    class Program
    {
        public static (int, string, string) ReturnTuple()
        {
            return (1, "2", "tuple");
        }

        static void Main(string[] args)
        {
            (int, string) myTuple1 = (1, "1");
            Console.WriteLine($"Type: {myTuple1.GetType()} , Base Type: {myTuple1.GetType().BaseType}");

            ValueTuple<int, string> myTuple2 =  new ValueTuple<int,string>(2,"2");
            Console.WriteLine($"Type: {myTuple2.GetType()} , Base Type: {myTuple2.GetType().BaseType}");

            Tuple<int, string> myTuple3 = new Tuple<int, string>(3, "3");
            Console.WriteLine($"Type: {myTuple3.GetType()} , Base Type: {myTuple3.GetType().BaseType}");

            Console.WriteLine(ReturnTuple());

            Console.ReadLine();
        }
    }
}
