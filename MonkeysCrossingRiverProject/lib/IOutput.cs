using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysCrossingRiverProject.lib
{
    public interface IOutput
    {
        void Start(int rightCount, int leftCount);
        void Write(MonkeyManager.Sides side, int count, bool[] ropePositions);
        void Finish(int iterations);
        void Wait();
    }
}
