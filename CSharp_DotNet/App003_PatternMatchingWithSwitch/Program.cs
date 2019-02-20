using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App003_PatternMatchingWithSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            object item1 = 1;
            object item2 = "1";

            switch (item1)
            {
                case int i:
                    Console.WriteLine($"Item {i} is an integer.");
                    break;
                case string i:
                    Console.WriteLine($"Item {i} is an string.");
                    break;

            }

            switch (item2)
            {
                case int j:
                    Console.WriteLine($"Item {j} is an integer.");
                    break;
                case string j:
                    Console.WriteLine($"Item {j} is an string.");
                    break;

            }

            Console.ReadLine();
        }
    }
}
