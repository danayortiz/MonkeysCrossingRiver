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

            var manager = new lib.MonkeyManager(output, 3, 4, 3);

            manager.Run();

            Console.ReadKey();
        }
    }
}
