using System;

namespace BowlingGame
{
    public class BowlingGameEngine
    {
        private readonly int[] _rolls = new int[21];
        private int _rollsIndex = 0;

        public void Roll(int pinsDown)
        {
            _rolls[_rollsIndex++] = pinsDown;
        }

        public int Score()
        {
            var score = 0;
            var frameIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (IsSpare(frameIndex)){
                    score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                } 
                else
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }

            return score;
        }

        private bool IsSpare(int rollIndex)
        {
            return _rolls[rollIndex] + _rolls[rollIndex+1] == 10;
        }

        private bool IsStrike(int rollIndex)
        {
            return _rolls[rollIndex] == 10;
        }
    }
}
