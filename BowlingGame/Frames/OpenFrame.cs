using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Frames
{
    class OpenFrame : IFrame
    {
        public int[] Rolls { get; set; }

        public OpenFrame(int[] rolls)
        {
            Rolls = rolls;
        }

        public int ScoreFrame(IFrame nextFrame, IFrame secondFrame)
        {
            return Rolls.Sum();
        }

        public void Validate()
        {
            if (Rolls.Length > 2)
                throw new ArgumentOutOfRangeException("A frame cannot have more than two rolls.");

            if (Rolls.Sum() > 9)
                throw new ArgumentOutOfRangeException("An open frame cannot have more than nine pins.");

        }
    }
}
