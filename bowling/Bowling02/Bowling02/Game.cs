using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bowling02
{
    class Game
    {
        int[] _rolls = new int[21];
        int _rollIndex = 0;

        internal void Roll(int pinsDowned)
        {
            _rolls[_rollIndex++] = pinsDowned;
        }

        internal int GetScore()
        {
            int sum = 0;
            int frameIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                if (_rolls[frameIndex] == 10)
                {
                    sum += SumAsStrike(frameIndex);
                    frameIndex++;
                }
                else if (FrameIsSpare(frameIndex))
                {
                    sum += SumAsSpare(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    sum += SumAsStandardFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return sum;
        }

        private int SumAsStrike(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
        }

        private bool FrameIsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }

        private int SumAsSpare(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 2];
        }

        private int SumAsStandardFrame(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1];
        }
    }
}
