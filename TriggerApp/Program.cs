using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path =
                @"C:\Users\ansab.iqbal\Documents\Visual Studio 2015\Projects\Console Projects\OpeningConsoleAppWithArgs\OpeningConsoleAppWithArgs\bin\Debug\OpeningConsoleAppWithArgs.exe";
            string Arguments = "LikedBusiness SignUp Register";

            System.Diagnostics.Process.Start(Path, Arguments);

            Console.WriteLine("Process Started");
            Console.ReadKey();
        }
    }
}

// Git Comment
