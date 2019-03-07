using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace App026_SystemDiagnostics_ProcessOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var processes = Process.GetProcesses().OrderBy(x => x.Id);

            foreach (Process p in processes)
            {
                Console.WriteLine($"Process Id: {p.Id}, Process Name: {p.ProcessName}");
            }


            // Investigating ThreadSets of Visual Studio
            Process specificPro = Process.GetProcesses().Where(x => x.ProcessName.Contains("devenv")).FirstOrDefault();
            foreach (ProcessThread thread in specificPro.Threads)
            {
                Console.WriteLine($"Thread: {thread.Id}, Thread Start Time: {thread.StartTime}");
            }

            // Investigation Process Modules
            foreach (ProcessModule mod in specificPro.Modules)
            {
                Console.WriteLine($"Module Name: {mod.ModuleName}");
            }

            Console.ReadLine();
        }
    }
}
