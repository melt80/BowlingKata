using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{

    public class Game
    {

        public List<IFrame> Frames;

        public Game(List<IFrame> frames)
        {
            Frames = frames;
        }

        public void Validate()
        {
            if (Frames.Count > 10)
            {
                throw new ArgumentOutOfRangeException("There should be 10 frames.");
            }
        }

        public int ScoreGame()
        {
            int _totalScore = 0;
            for (int i = 0; i < Frames.Count; i++)
            {
                Frames[i].Validate();
                if (i < Frames.Count - 2)
                {
                    _totalScore += Frames[i].ScoreFrame(Frames[i + 1], Frames[i + 2]);
                }
                else if (i == Frames.Count - 2)
                {
                    _totalScore += Frames[i].ScoreFrame(Frames[i + 1], null);
                }
                else
                {
                    _totalScore += Frames[i].ScoreFrame(null, null);
                }
            }

            return _totalScore;
        }
    }
}