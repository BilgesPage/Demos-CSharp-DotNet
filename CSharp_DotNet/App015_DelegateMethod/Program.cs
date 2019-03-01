using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App015_DelegateMethod
{
    public delegate int DelegateMathMethod(int x, int y);

    public class MyMath
    {
        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;
    }

    public delegate void GenericDelegate<T>(T args);

    public class MethodsForGenericDelegate
    {
        public static void Print01(int msgNo)
        {
            Console.WriteLine($"Print01 Message: {msgNo}");
        }

        public static void Print02()
        {
            Console.WriteLine("Print02 Message");
        }

        public static void Print03(string msg)
        {
            Console.WriteLine($"Print03 Message: {msg}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Start delegation
            DelegateMathMethod myDelegateMathMethod = new DelegateMathMethod(MyMath.Add);
            Console.WriteLine($"Add: {myDelegateMathMethod(1, 2)}");

            // Append Delegation (Multicasting)
            myDelegateMathMethod += new DelegateMathMethod(MyMath.Multiply);
            Console.WriteLine($"Multiply: {myDelegateMathMethod(1, 2)}");

            //Execute Delegation by iteration
            foreach (Delegate del in myDelegateMathMethod.GetInvocationList())
            {
                Console.WriteLine($"Method: {del.Method}");
                Console.WriteLine($"Target (Type Name): {del.Target}");
            }

            // Using Custom Generic Delegate
            GenericDelegate<string> myGenericDelegate1 = new GenericDelegate<string>(MethodsForGenericDelegate.Print03);
            GenericDelegate<int> myGenericDelegate2 = new GenericDelegate<int>(MethodsForGenericDelegate.Print01);
            myGenericDelegate1.Invoke("Hello");
            myGenericDelegate2.Invoke(5);

            // Using Action<> Generic Delegate
            Action<string> myActionDelegate = new Action<string>(MethodsForGenericDelegate.Print03);
            myActionDelegate.Invoke("Hello from Action Delegate");

            // Using Func Delegate (final parameter type is the return value)
            Func<int, int, int> myFuncDelegate = new Func<int, int, int>(MyMath.Add);
            int result = myFuncDelegate.Invoke(3,4);
            Console.WriteLine($"3 + 4 = { result}");


            Console.ReadLine();
        }
    }
}
