using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject.lib
{
    public class Rope
    {
        private int _count;
        private int _capacity = 3;
        private bool[] _positions;

        public int Count
        {
            get { return _count; }
        }

        public int Capacity
        {
            get { return _capacity; }
        }

        public Rope()
        {
            _positions = new bool[_capacity];
        }

        /// <summary>
        /// Check if there is a space where a monkey can
        /// be added. It will check only first space in the array
        /// </summary>
        /// <returns>Returns TRUE if there is a space</returns>
        public bool IsSpaceAvailable()
        {
            return !_positions[0];
        }

        /// <summary>
        /// Check if the rope is empty.
        /// </summary>
        /// <returns>Returns TRUE is there are not monkeys in the rope</returns>
        public bool IsEmpty()
        {
            return _count == 0;
        }

        /// <summary>
        /// Adds a monkey to the rope in the initial position
        /// </summary>
        public bool AddMonkey()
        {
            if (!IsSpaceAvailable())
            {
                return false;
            }

            _positions[0] = true;
            _count++;
            return true;
        }

        /// <summary>
        /// Move all existing monkeys one position forward.
        /// Keeps internal count up to date
        /// </summary>
        public int MoveMonkeys()
        {
            if (IsEmpty())
            {
                return _count;
            }

            _count = 0;
            for (int i = _positions.Count() - 1; i > 0; i--)
            {
                _positions[i] = _positions[i - 1];
                _positions[i - 1] = false;
                if (_positions[i])
                {
                    _count++;
                }
            }

            return _count;
        }
    }
}
