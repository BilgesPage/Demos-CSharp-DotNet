using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App006_SystemEnum
{
    class Program
    {
        enum EmployeeType
        {
            Masnager = 2,
            VicePresident = 1,
            Contractor = 100,
            Grunt = 45
        }

        static void Main(string[] args)
        {
            // Get underlying type
            EmployeeType emp = EmployeeType.Contractor;
            Console.WriteLine(Enum.GetUnderlyingType(emp.GetType()));

            // Get name and values of enum
            Console.WriteLine($"Value: { emp.ToString()}, Name: {Convert.ToInt32(emp)}");


            // Get all enum names and values
            Array empEnumData = Enum.GetValues(EmployeeType.Contractor.GetType());

            for (int i = 0; i< empEnumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",empEnumData.GetValue(i)); // D returns decimal value of the enum
            }


            Console.ReadLine();

        }
    }
}
