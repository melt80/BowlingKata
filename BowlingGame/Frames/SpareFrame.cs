using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Frames
{
    class SpareFrame : IFrame
    {
        public int[] Rolls { get; set; }

        public SpareFrame(int[] rolls)
        {
            Rolls = rolls;
        }

        public int ScoreFrame(IFrame nextFrame, IFrame secondFrame)
        {
            if (nextFrame == null)
                throw new ArgumentException("Next frame cannot be null.");

            return (Rolls.Sum() + nextFrame.Rolls[0]);
        }

        public void Validate()
        {

            if (Rolls.Sum() != 10)
                throw new ArgumentOutOfRangeException("The sum of rolls in an spare frame must be equal to 10.");
            if (Rolls[0] == 10)
                throw new ArgumentOutOfRangeException("The first roll of a spare frame cannot be 10.");
            if (Rolls.Length > 2)
                throw new ArgumentException("A spare frame cannot have more than two rolls.");
        }
    }
}
