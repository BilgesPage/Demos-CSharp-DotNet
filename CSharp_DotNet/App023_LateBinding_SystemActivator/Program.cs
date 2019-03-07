using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App023_LateBinding_SystemActivator
{
    class Program
    {
        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                Type myCarType = asm.GetType("CarClassLibrary.Car");

                object obj = Activator.CreateInstance(myCarType);

                MethodInfo constructor = myCarType.GetMethod("Car");
                constructor.Invoke(obj, null);

                Console.WriteLine($"The {obj.GetType().Name} created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Main(string[] args)
        {
            try
            {
                Assembly asm = Assembly.Load("CarClassLibrary");

                CreateUsingLateBinding(asm);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
