// C# program to print backslash (\)
using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test3
    {
        // Main Method 
        static void Main(string[] args)
        {
            // printing "\" 
            Console.WriteLine("\\");

            // printing between string "\"
            Console.WriteLine("Hello\\World");

            // printing "\"n and "\"t
            Console.WriteLine("Hello\x0AWorld");
            Console.WriteLine();
            Console.WriteLine("\\n\\t");

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
