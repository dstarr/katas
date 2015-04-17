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
                if (_rolls[i] == 10)
                {
                    score += 10 + _rolls[i + 1] + _rolls[i + 2];
                    i++;
                }
                else if (_rolls[i] + _rolls[i + 1] == 10)
                {
                    score += 10 + _rolls[i+2];
                    i += 2;
                }
                else
                {
                    score += _rolls[i] + _rolls[i + 1];
                    i += 2;
                }
            }
            



            return score;
        }
    }
}
