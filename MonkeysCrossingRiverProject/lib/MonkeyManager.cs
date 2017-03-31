using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject.lib
{
    public class MonkeyManager
    {
        private int _rightCount;
        private int _leftCount;
        private int _maxPerRound;
        private IOutput _output;
        private Rope _rope = new Rope();
        public enum Sides { Right, Left };

        public int RightCount
        {
            get { return _rightCount; }
        }

        public int LeftCount
        {
            get { return _leftCount; }
        }

        public MonkeyManager(IOutput output, int rightCount, int leftCount, int maxPerRound = 3)
        {
            this._rightCount = rightCount;
            this._leftCount = leftCount;
            this._maxPerRound = maxPerRound;
            this._output = output;
        }

        /// <summary>
        /// Resolve a side to start with
        /// </summary>
        /// <returns>Returns a side to start with</returns>
        protected Sides PickASide()
        {
            return _leftCount > _rightCount ? Sides.Left : Sides.Right;
        }
        
        protected Sides SwitchSides(Sides current)
        {
            if (current == Sides.Left && _rightCount > 0)
            {
                current = Sides.Right;
            } else if (_leftCount > 0)
            {
                current = Sides.Left;
            }
            return current;
        }
        /// <summary>
        /// Run all necessary iterations to move all monkeys
        /// from one side to another
        /// </summary>
        /// <returns>Returns number of iterations done</returns>
        public int Run()
        {
            _output.Start(_rightCount, _leftCount);

            var iterations = 0;
            var currentSide = PickASide();
            while (_rightCount > 0 || _leftCount > 0)
            {
                iterations += DoRound(currentSide);
                currentSide = SwitchSides(currentSide);
            }

            _output.Finish(iterations);

            return iterations;
        }

        /// <summary>
        ///Take the allowed amount of monkeys to the other side.
        /// </summary>
        /// <param name="count">Number of total monkeys on one side waiting to cross.</param>
        /// <returns>Returns number of iterations.</returns>
        private int DoRound(Sides side)
        {
            var count = side == Sides.Left ? _leftCount : _rightCount;
            var i = 0;
            do
            {
                _rope.MoveMonkeys();
                if (count > 0 && i < _maxPerRound)
                {
                    _rope.AddMonkey();
                    count--;
                }
                i++;
                _output.Write(side, count, _rope.Positions);
                _output.Wait();
            } while (!_rope.IsEmpty());

            if (side == Sides.Left)
            {
                _leftCount = count;
            }
            else
            {
                _rightCount = count;
            }
            return i;
        }
    }
}
