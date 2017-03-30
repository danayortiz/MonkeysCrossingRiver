using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject.lib
{
    public class Rope
    {
        private int count;
        private bool[] positions = new bool[3];

        /// <summary>
        /// Check if there is a space where a monkey can
        /// be added. It will check only first space in the array
        /// </summary>
        /// <returns>Returns TRUE if there is a space</returns>
        public bool IsSpaceAvailable()
        {
            return !this.positions[0];
        }

        /// <summary>
        /// Check if the rope is empty.
        /// </summary>
        /// <returns>Returns TRUE is there are not monkeys in the rope</returns>
        public bool IsFree()
        {
            return count == 0;
        }

        /// <summary>
        /// Adds a monkey to the rope in the initial position
        /// </summary>
        public bool AddMonkey()
        {
            if (!this.IsSpaceAvailable())
            {
                return false;
            }

            positions[0] = true;
            count++;
            return true;
        }

        /// <summary>
        /// Move all existing monkeys one position forward.
        /// Keeps internal count up to date
        /// </summary>
        public void MoveMonkeys()
        {

        }
    }
}
