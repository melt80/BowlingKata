using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public interface IFrame
    {
        int[] Rolls { get; set; }
        int ScoreFrame(IFrame nextFrame, IFrame secondFrame);
        void Validate();
    }
}
