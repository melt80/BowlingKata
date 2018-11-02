using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Frames
{
    public class StrikeFrame : IFrame
    {
        public int[] Rolls { get; set; }

        public StrikeFrame(int[] rolls)
        {
            Rolls = rolls;
        }

        public int ScoreFrame(IFrame nextFrame, IFrame secondFrame)
        {
            if (nextFrame == null)
                throw new ArgumentException("Next frame cannot be null.");

            if (nextFrame is StrikeFrame)
            {
                if (secondFrame == null)
                    throw new ArgumentException("Second frame cannot be null.");

                return (Rolls.Sum() + nextFrame.Rolls[0] + secondFrame.Rolls[0]);
            }
            else
                return (Rolls.Sum() + nextFrame.Rolls[0] + nextFrame.Rolls[1]);
        }

        public void Validate()
        {
            if (Rolls[0] != 10 || Rolls.Length != 1)
                throw new ArgumentException("A strike frame must have one roll of 10 pins.");
        }
    }
}
