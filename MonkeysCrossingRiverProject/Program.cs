using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monkeys Crossing River");

            var output = new lib.ConsoleOutput();
            var leftCount = 0;
            var rightCount = 0;

            Int32.TryParse(args[0], out leftCount);
            Int32.TryParse(args[1], out rightCount);

            var manager = new lib.MonkeyManager(output, rightCount, leftCount, 3);

            manager.Run();

            Console.ReadKey();
        }
    }
}
