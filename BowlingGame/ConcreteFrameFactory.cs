using BowlingGame.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class ConcreteFrameFactory : FrameFactory
    {
        public override IFrame MakeFrame(int[] rolls)
        {
            if (rolls.Length == 1 && rolls.Sum() == 10)
                return new StrikeFrame(rolls);

            else if (rolls.Length == 2 && rolls.Sum() == 10)
                return new SpareFrame(rolls);

            else if (rolls.Length > 2)
                return new BonusFrame(rolls);

            else
                return new OpenFrame(rolls);
        }
    }
}
