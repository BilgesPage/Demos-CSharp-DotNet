using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App007_ValueTypeAndReferenceType
{
    class Program
    {
        // Value Type: Allocated on the stack
        struct MyValueType
        {
            // Default constructor of struct is reserved. This is not applicable
            //public MyValueType()
            //{

            //}

            public double  X;

            public double Multiply()
            {
                return X * X;
            }
        }


        class MyReferenceType
        {
            public double X;

            public double Multiply()
            {
                return X * X;
            }

        }


        static void Main(string[] args)
        {
            // Value Type
            MyValueType myValueType = new MyValueType();
            myValueType.X = 999999999999999;
            Console.WriteLine(myValueType.Multiply());

            // Reference Type
            MyReferenceType myReferenceType = new MyReferenceType();
            myReferenceType.X = 999999999999999;
            Console.WriteLine(myReferenceType.Multiply());



            Console.ReadLine();
        }
    }
}
