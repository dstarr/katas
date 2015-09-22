using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling08_SpecFlow
{
    class Game
    {
        private readonly IList<int> _rolls = new List<int>();
        
        public void Roll(int pinsDown)
        {
            _rolls.Add(pinsDown);
        }

        public int GetScore()
        {
            int score = 0;
            int i = 0;
            
            for (int frameIndex = 0; frameIndex < 10; frameIndex++)
            {
                if (FrameIsStrike(i))
                {
                    score += AddStrikeScore(i);
                    i++;
                }
                else if (FrameIsSpare(i))
                {
                    score += AddSpareScore(i);
                    i += 2;
                }
                else
                {
                    score += AddTypicalFrameScore(i);
                    i += 2;
                }
            }
            
            return score;
        }

        private int AddTypicalFrameScore(int i)
        {
            return _rolls[i] + _rolls[i + 1];
        }

        private int AddSpareScore(int i)
        {
            return 10 + _rolls[i+2];
        }

        private int AddStrikeScore(int i)
        {
            return 10 + _rolls[i + 1] + _rolls[i + 2];
        }

        private bool FrameIsSpare(int i)
        {
            return _rolls[i] + _rolls[i + 1] == 10;
        }

        private bool FrameIsStrike(int i)
        {
            return _rolls[i] == 10;
        }
    }
}
