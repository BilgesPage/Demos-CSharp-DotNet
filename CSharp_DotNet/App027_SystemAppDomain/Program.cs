using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace App027_SystemAppDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain defaultAppD = AppDomain.CurrentDomain;

            if (defaultAppD.IsDefaultAppDomain())
            {
                Console.WriteLine($"Name: {defaultAppD.FriendlyName}");
                Console.WriteLine($"Id: {defaultAppD.Id}");
                Console.WriteLine($"Base Directory: {defaultAppD.BaseDirectory}");
                Console.WriteLine($"Is Default: {defaultAppD.IsDefaultAppDomain()}");
            }


            Assembly[] assemblies = defaultAppD.GetAssemblies();
            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine($"Assembly Full Name: {asm.GetName().Name}");
                Console.WriteLine($"Assembly Full Name: {asm.GetName().Version}");
            }


            //Create new AppDomain
            AppDomain newAppD = AppDomain.CreateDomain("SecondAppDomain");
            foreach (Assembly asm in newAppD.GetAssemblies())
            {
                Console.WriteLine($"Assembly Name: {asm.GetName().Name}");
            }

            
            AppDomain.Unload(newAppD);

            Console.ReadLine();
        }
    }
}
