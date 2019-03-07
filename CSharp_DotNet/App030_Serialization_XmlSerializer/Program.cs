using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace App030_Serialization_XmlSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Car));

            using (Stream fStream = new FileStream("Test.xml", FileMode.Create, FileAccess.ReadWrite))
            {
                xmlFormat.Serialize(fStream, new Car { Brand = "Opel", Color = "Red" });
            }

            

            Console.ReadLine();


        }
    }
}
