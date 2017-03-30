using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject.lib
{
    class MonkeyManager
    {
        private int rightCount;
        private int leftCount;
        protected enum Sides { Right, Left };

        public MonkeyManager(int rightCount, int leftCount)
        {
            this.rightCount = rightCount;
            this.leftCount = leftCount;
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
