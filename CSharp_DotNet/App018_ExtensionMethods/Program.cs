using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App018_ExtensionMethods
{
    public static class MyExtensions
    {
        public static void DisplayAssemblyDetails(this object obj)
        {
            Console.WriteLine($"This : {obj.GetType().Name} object lives here: {Assembly.GetAssembly(obj.GetType()).GetType().Name}");

        }

        public static int ReverseDigits(this int num)
        {
            char[] chars = num.ToString().ToCharArray();

            Array.Reverse(chars);

            string str = new string(chars);

            return int.Parse(str);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int myInt = 123456789;

            Console.WriteLine($"Before reverse: {myInt}");

            Console.WriteLine($"After reverse with extension method: {myInt.ReverseDigits()}");

            String myStr = "Hello";
            myStr.DisplayAssemblyDetails();
            

            Console.ReadLine();

        }
    }
}
