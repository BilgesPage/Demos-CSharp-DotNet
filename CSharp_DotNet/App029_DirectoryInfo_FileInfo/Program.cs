using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App029_DirectoryInfo_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Curent Directory
            DirectoryInfo dir01 = new DirectoryInfo(".");
            Console.WriteLine($"FullName: {dir01.FullName}");
            Console.WriteLine($"Root: {dir01.Root}");

            DirectoryInfo dir02 = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine($"FullName: {dir02.FullName}");
            Console.WriteLine($"Root: {dir02.Root}");

            DirectoryInfo dir03 = new DirectoryInfo(@"C:\MyCode\Test");
            dir03.Create();
            dir03.CreateSubdirectory(@"SubDir");
            Console.WriteLine($"FullName: {dir03.FullName}");
            Console.WriteLine($"Root: {dir03.Root}");

            // List Directory Files
            DirectoryInfo dirWallPapers = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            FileInfo[] wallpapers = dirWallPapers.GetFiles("*.jpg",SearchOption.AllDirectories);

            foreach (FileInfo fi in wallpapers)
            {
                Console.WriteLine($"FullName: {fi.FullName}");
                Console.WriteLine($"Length: {fi.Length}");
            }

            // List Drives on the computer
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drv in drives)
            {
                Console.WriteLine(drv);
            }

            DriveInfo[] driveInfoArr = DriveInfo.GetDrives();
            foreach (DriveInfo info in driveInfoArr)
            {
                Console.WriteLine($"Name: {info.Name}");
                if(info.IsReady)
                {
                    Console.WriteLine($"Total Free Space: {info.TotalFreeSpace}");
                }
                
            }

            // Create File
            FileInfo fi3 = new FileInfo(@"C:\MyCode\Test\Test.dat");
            using (FileStream fstrm = fi3.Create())
            {
                   // TODO
            }


            FileInfo fi2 = new FileInfo(@"C:\MyCode\Test\Test2.dat");
            using (FileStream fstrm2 = fi2.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                // TODO
            }

            // Obtain FileStream object with File
            FileStream fstrm3 = File.Open(@"C:\MyCode\Test\Test3.dat",FileMode.OpenOrCreate);

            // Create StreamWriter & StreamReader

            using (StreamWriter strWr = File.CreateText(@"C:\MyCode\Test\Test4.txt"))
            {
                strWr.WriteLine("Line01");
                strWr.WriteLine("Line02");
                strWr.WriteLine("Line03");

            }

            using (StreamReader strRedr = File.OpenText(@"C:\MyCode\Test\Test4.txt"))
            {
                while (!strRedr.EndOfStream)
                {
                    Console.WriteLine(strRedr.ReadLine());
                }
            }

            using (StreamReader strRedr = File.OpenText(@"C:\MyCode\Test\Test4.txt"))
            {
                Console.WriteLine(strRedr.ReadToEnd());
            }

            Console.ReadLine();

        }
    }
}
