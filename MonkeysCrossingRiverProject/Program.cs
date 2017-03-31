using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject
{
    class Program
    {
        static void printHelp()
        {
            Console.WriteLine("Usage: MonkeysCrossingRiver.exe <left count> <right count>");
            Console.WriteLine("Arguments:");
            Console.WriteLine("     Left count: Amount of monkeys on the left side. (Required)");
            Console.WriteLine("     Right count: Amount of monkeys on the right side. (Required)");
            Console.WriteLine(" ");

            System.Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                printHelp(); 
            }

            var leftCount = 0;
            var rightCount = 0;

            Int32.TryParse(args[0], out leftCount);
            Int32.TryParse(args[1], out rightCount);

            if (leftCount < 0 || rightCount < 0)
            {
                printHelp();
            }

            var output = new lib.ConsoleOutput();
            var manager = new lib.MonkeyManager(output, rightCount, leftCount, 3);

            manager.Run();

            Console.ReadKey();
        }
    }
}
