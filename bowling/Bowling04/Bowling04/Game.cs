using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling04
{
    class Game
    {
        private readonly int[] _rolls = new int[21];
        private int _rollIndex = 0;

        internal void Roll(int pinsDown)
        {
            _rolls[_rollIndex++] = pinsDown;
        }

        internal int GetScore()
        {
            int frameIndex = 0;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                if (FrameIsStrike(frameIndex))
                {
                    sum += SumStrikeFrame(frameIndex);
                    frameIndex++;
                }
                else if (FrameIsSpare(frameIndex))
                {
                    sum += SumSpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    sum += SumNormalFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return sum;   
        }

        private bool FrameIsStrike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }

        private int SumStrikeFrame(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
        }

        private int SumNormalFrame(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1];
        }

        private int SumSpareBonus(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 2];
        }

        private bool FrameIsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}
