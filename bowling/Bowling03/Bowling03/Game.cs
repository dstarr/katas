using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling03
{
    class Game
    {
        readonly int[] _rolls = new int[21];
        int _rollIndex = 0;

        internal void Roll(int pinsDown)
        {
            _rolls[_rollIndex++] = pinsDown;
        }

        internal int GetScore()
        {
            int sum = 0;
            int frameIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                if (FrameIsStrike(frameIndex))
                {
                    sum += SumStrikeFrame(frameIndex);
                }
                else if (FrameIsSpare(frameIndex))
                {
                    sum += SumSpareFrame(frameIndex);
                }
                else
                {
                    sum += SumSimpleFrame(frameIndex);
                }
                frameIndex += 2;
            }

            return sum;
        }

        private int SumStrikeFrame(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
        }

        private int SumSpareFrame(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 2];
        }

        private int SumSimpleFrame(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1];
        }

        private bool FrameIsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }

        private bool FrameIsStrike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }
    }

}
