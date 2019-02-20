using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App001_SystemEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Environment.GetLogicalDrives(); ");
            foreach (var item in Environment.GetLogicalDrives())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            Console.WriteLine($"OSVersion: {Environment.OSVersion}");

            Console.WriteLine($"Number of processors: {Environment.ProcessorCount} ");

            Console.WriteLine($".NET Version: {Environment.Version}");

            Console.WriteLine($"Folder path: {Environment.GetFolderPath(Environment.SpecialFolder.Windows)}");

            Console.WriteLine($"User name: {Environment.UserName}");

            Console.ReadLine();

        }
    }
}
