using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject.lib
{
    class ConsoleOutput : IOutput
    {
        private string _waitingMonkey = ":/";
        private string _happyMonkey = ":D";
        private string _empty = "  ";

        public void Finish(int iterations)
        {
            Console.CursorTop = 5;
            Console.WriteLine(" ");
            Console.WriteLine("Program finished after {0} iterations", iterations);
        }

        public void Start(int rightCount, int leftCount)
        {
            Console.Clear();

            Console.WriteLine("Monkeys Crossing River");
            Console.WriteLine("Program started");
            Console.WriteLine(" ");

            Console.CursorLeft = 3;
            Console.Write("{0} [{1}]", _waitingMonkey, this.format(leftCount));
            Console.Write("   ┬──────┼─────┼─────┼─────┬  ");
            Console.Write("{0} [{1}]", _waitingMonkey, this.format(rightCount));

            this.Wait();
        }

        public void Wait()
        {
            System.Threading.Thread.Sleep(1000);
        }

        // TODO: Support 3 and more digit numbers
        private string format(int number)
        {
            var str = number.ToString();

            return (str.Length < 2 ? "0" : "") + str;
        }

        public void Write(MonkeyManager.Sides side, int count, bool[] ropePositions)
        {
            if (side == MonkeyManager.Sides.Left)
            {
                Console.CursorLeft = 7;
            }
            else
            {
                Console.CursorLeft = 45;
            }

            Console.CursorTop = 3;
            Console.Write(this.format(count));

            Console.CursorTop = 2;

            for (var i = 0; i < ropePositions.Count(); i++)
            {
                if (side == MonkeyManager.Sides.Left)
                {
                    Console.CursorLeft = 19 + (i * 6);
                } 
                else
                {
                    Console.CursorLeft = 31 - (i * 6);
                }
                
                if (ropePositions[i])
                {
                    Console.Write(_happyMonkey);
                } 
                else
                {
                    Console.Write(_empty);
                }
            }
            
        }
    }
}
