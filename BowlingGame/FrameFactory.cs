using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public abstract class FrameFactory
    {
        public abstract IFrame MakeFrame(int[] rolls);
    }
}
