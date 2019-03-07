using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App028_Thread
{
    class Program
    {
        class Writer
        {
            public void WriteMessage()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            // Retrieve Thread properties
            Thread currentThread = Thread.CurrentThread;

            Console.WriteLine($"Thread Current Culture: {currentThread.CurrentCulture}");
            Console.WriteLine($"Thread Name: {currentThread.Name}");
            Console.WriteLine($"Thread State: {currentThread.ThreadState}");
            Console.WriteLine($"Thread IsBackground: {currentThread.IsBackground}");

            // Retrieve AppDomain properties
            AppDomain currentAppDomain = Thread.GetDomain();
            Console.WriteLine($"AppDomain FriendlyName: {currentAppDomain.FriendlyName}");

            // Retrieve Context properties
            Context currentContext = Thread.CurrentContext;
            Console.WriteLine($"Context Id: {currentContext.ContextID}");

            //Creating new thread
            Thread.CurrentThread.Name = "First";

            Writer writer = new Writer();
            Thread secondThread = new Thread(new ThreadStart(writer.WriteMessage));
            secondThread.Name = "Second";

            Thread thirdThread = new Thread(new ThreadStart(writer.WriteMessage));
            thirdThread.Name = "Third";

            secondThread.Start();
            thirdThread.Start();


            Console.ReadLine();
        }
    }
}
