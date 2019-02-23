using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App004_NamedParameters
{
    class Program
    {
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // Get current color settings
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            // Appşy new color settings
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // Undo new color settings
            Console.WriteLine("Press any key to undo color settings");
            Console.ReadLine();

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
            Console.WriteLine("Undo completed");

            Console.ReadLine();

        }

        static void Main(string[] args)
        {

            DisplayFancyMessage(ConsoleColor.Blue, ConsoleColor.Yellow, message: "This is my named parameter message");

        }
    }
}
