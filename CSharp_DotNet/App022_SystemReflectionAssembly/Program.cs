using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App022_SystemReflectionAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assem01 = Assembly.Load("CarClassLibrary");
            foreach (var item in assem01.GetType().GetProperties())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Number Format -> Currency Symbol: {assem01.GetName().CultureInfo.NumberFormat.CurrencySymbol}");
            Console.WriteLine($"Culture Display Name: {assem01.GetName().CultureInfo.DisplayName}");

            Console.ReadLine();
        }
    }
}
