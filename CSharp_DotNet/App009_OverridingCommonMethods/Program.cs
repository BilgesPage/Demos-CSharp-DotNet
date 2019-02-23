using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App009_OverridingCommonMethods
{
    internal class Test
    {
        public string MyProperty { get; set; }

        public override string ToString() => "My Property " + MyProperty + " Overriden String";

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*
         * 
         */

        public override int GetHashCode()
        {
            return -215744790 + EqualityComparer<string>.Default.GetHashCode(MyProperty);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Test test = new Test
            {
                MyProperty = "value"
            };


            Console.WriteLine(test.ToString());
            Console.WriteLine(test.Equals("temp"));

            Console.ReadLine();
        }
    }
}

