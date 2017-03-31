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

            var manager = new lib.MonkeyManager(4, 9, 3);

            Console.WriteLine(manager.Run());

            Console.ReadKey();
        }
    }
}
