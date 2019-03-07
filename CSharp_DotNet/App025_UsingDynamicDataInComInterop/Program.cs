using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App025_UsingDynamicDataInComInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Managing Dynamic Data
            Car myCar = new Car();
            ExportDataTo.ExportToExcel(myCar.Cars);


            // Using Dynamic Type
            dynamic myDynamicParam = new Car();
            Console.WriteLine(myDynamicParam);

            myDynamicParam = "Hello";
            Console.WriteLine(myDynamicParam);

            myDynamicParam = myCar.Cars;
            Console.WriteLine(myDynamicParam);

            Console.ReadLine();

        }
    }
}
