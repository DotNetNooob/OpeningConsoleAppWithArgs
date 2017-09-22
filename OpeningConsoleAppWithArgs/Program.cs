using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningConsoleAppWithArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (var item in args)
                {
                    Console.WriteLine(item);
                }
            }
            // Initial Commit 2
            Console.ReadKey();
        }
    }
}
