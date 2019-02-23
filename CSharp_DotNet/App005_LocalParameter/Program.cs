using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App005_LocalFunctions
{
    class Program
    {
        static int AddOperator(int x, int y)
        {
            return Add();

            // This is the local function/method
             int Add()
            {
                return x + y;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddOperator(1, 2));
            Console.ReadLine();
        }
    }
}
