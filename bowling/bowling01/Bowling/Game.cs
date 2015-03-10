using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _rollIndex = 0;

        public void Roll(int pinsDowned)
        {
            _rolls[_rollIndex++] = pinsDowned;
        }

        public int GetScore()
        {
            int sum = 0;
            int frameIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                if (FrameIsAStrike(frameIndex))
                {
                    sum += SumFrameAsStrike(frameIndex);
                    frameIndex = +1;
                }
                else if (FrameIsASpare(frameIndex))
                {
                    sum += SumFrameAsSpare(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    sum += SumFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return sum;
        }

        private int SumFrameAsStrike(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
        }

        private bool FrameIsAStrike(int frameIndex)
        {
            return _rolls[frameIndex] == 10;
        }

        private int SumFrame(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1];
        }

        private int SumFrameAsSpare(int frameIndex)
        {
            return 10 + _rolls[frameIndex + 2];
        }

        private bool FrameIsASpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}
