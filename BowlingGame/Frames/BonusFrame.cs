using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Frames
{
    public class BonusFrame : IFrame
    {
        public int[] Rolls { get; set; }

        public BonusFrame(int[] rolls)
        {
            Rolls = rolls;
        }

        public int ScoreFrame(IFrame nextFrame, IFrame secondFrame)
        {
            return Rolls.Sum();
        }

        public void Validate()
        {
            if (Rolls.Length > 3)
                throw new ArgumentOutOfRangeException("A bonus frame cannot have more than three rolls.");
        }
    }
}
