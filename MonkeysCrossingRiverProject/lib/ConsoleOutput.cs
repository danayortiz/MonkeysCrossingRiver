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
            Console.WriteLine("Program started");
            Console.WriteLine(" ");

            Console.CursorLeft = 3;
            Console.Write("{0} [{1}]", _waitingMonkey, leftCount);
            Console.Write("   ┬──────┼─────┼─────┼─────┬  ");
            Console.Write("{0} [{1}]", _waitingMonkey, rightCount);

            this.Wait();
        }

        public void Wait()
        {
            System.Threading.Thread.Sleep(1000);
        }

        public void Write(MonkeyManager.Sides side, int count, bool[] ropePositions)
        {
            if (side == MonkeyManager.Sides.Left)
            {
                Console.CursorLeft = 7;
            }
            else
            {
                Console.CursorLeft = 44;
            }

            Console.CursorTop = 3;
            Console.Write(count);

            Console.CursorTop = 2;

            for (var i = 0; i < ropePositions.Count(); i++)
            {
                if (side == MonkeyManager.Sides.Left)
                {
                    Console.CursorLeft = 18 + (i * 6);
                } 
                else
                {
                    Console.CursorLeft = 30 - (i * 6);
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
