using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject.lib
{
    class MonkeyManager
    {
        private int _rightCount;
        private int _leftCount;
        protected enum Sides { Right, Left };

        public int RightCount
        {
            get { return _rightCount; }
        }

        public int LeftCount
        {
            get { return _leftCount; }
        }

        public MonkeyManager(int rightCount, int leftCount)
        {
            this._rightCount = rightCount;
            this._leftCount = leftCount;
        }

        /// <summary>
        /// Resolve a side to start with
        /// </summary>
        /// <returns>Returns a side to start with</returns>
        protected Sides PickASide()
        {
            return Sides.Left;
        }

        /// <summary>
        /// Run all necessary iterations to move all monkeys
        /// from one side to another
        /// </summary>
        /// <returns>Returns number of iterations done</returns>
        protected int Run()
        {
            return 0;
        }
    }
}
