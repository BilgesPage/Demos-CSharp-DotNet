using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App019_LINQ
{
    class Program
    {
        // LINQ With Primitive Arrays - LINQ Query Expression
        static void QueryStrings01()
        {
            string[] colors = { "Blue", "Red", "Yellow", "Green", "Purple"};

            IEnumerable<string> queried = from c in colors where c.Contains("l") orderby c select c;

            foreach (string str in queried)
            {
                Console.WriteLine(str);
            }
        }

        // LINQ With Primitive Arrays - LINQ Extension Method
        static void QueryStrings02()
        {
            string[] colors = { "Blue", "Red", "Yellow", "Green", "Purple" };

            IEnumerable<string> queried = colors.Where(c => c.Contains("l")).OrderBy(c => c).Select(c => c);

            foreach (string str in queried)
            {
                Console.WriteLine(str);
            }

        }

        // LINQ With Nongeneric Arrays
        static void QueryStrings03()
        {
            ArrayList stringList = new ArrayList() { "Blue", "Red", "Yellow", "Green", "Purple" };

            //IEnumerable<string> queried = stringList.Where() -----> Not Applicable this way

            IEnumerable<string> queried = stringList.OfType<string>().Where(c => c.Contains("l")).OrderBy(c => c).Select(c => c);

            foreach (string str in queried)
            {
                Console.WriteLine(str);
            }
        }

        static void Main(string[] args)
        {

            QueryStrings01();

            QueryStrings02();

            QueryStrings03();

            Console.ReadLine();

            
        }
    }
}
