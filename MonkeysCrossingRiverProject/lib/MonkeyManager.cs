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
        private Rope _rope = new Rope();
        protected enum Sides { Right, Left };

        public int RightCount
        {
            get { return _rightCount; }
        }

        public int LeftCount
        {
            get { return _leftCount; }
        }

        public MonkeyManager(int rightCount, int leftCount, int maxPerRound = 3)
        {
            this._rightCount = rightCount;
            this._leftCount = leftCount;
            this._maxPerRound = maxPerRound;
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
            return 0;
        }
    }
}
