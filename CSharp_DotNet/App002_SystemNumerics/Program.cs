using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace App002_SystemNumerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // using System.numerics
            System.Numerics.BigInteger myBigInteger = new BigInteger();
            BigInteger.TryParse("9999999999999999999999999999999999999999999999", out myBigInteger);

            Console.WriteLine($"BigInteger: {myBigInteger}");
            Console.WriteLine($"Is Even: {myBigInteger.IsEven}");
            Console.WriteLine($"Is Power of Two: {myBigInteger.IsPowerOfTwo}");
            Console.WriteLine($" myBigInteger * myBigInteger= { myBigInteger * myBigInteger }");

            Console.ReadLine();
        }
    }
}
