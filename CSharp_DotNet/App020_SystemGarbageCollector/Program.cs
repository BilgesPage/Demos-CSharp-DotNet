using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App020_SystemGarbageCollector
{
    class Program
    {
        class MyClass : IDisposable
        {
            public string Property01 { get; set; }

            // Finalize
            ~MyClass() => Console.WriteLine("MyClass Finalized");

            public void Dispose()
            {
                Console.WriteLine("MyClass Disposed");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine($"Estimated number of bytes on heap: {GC.GetTotalMemory(false)}");
            
            Console.WriteLine($"Max generation: {GC.MaxGeneration}");

            MyClass myClass = new MyClass();
            Console.WriteLine($"Generation of my Class object: {GC.GetGeneration(myClass)}");

            Console.WriteLine($"Estimated number of bytes on heap after creation of MyClass object: {GC.GetTotalMemory(false)}");

            GC.Collect();

            Console.WriteLine($"Estimated number of bytes on heap after forcing GC to Collect: {GC.GetTotalMemory(false)}");

            myClass.Dispose();

            using (MyClass myClass02 = new MyClass())
            {
                myClass02.Property01 = "Hello";

                Console.WriteLine(myClass02.Property01);
            }
            
                Console.ReadLine();
        }
    }
}
