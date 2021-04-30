using System;
using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class BowlingGameTest
    {
        private BowlingGameEngine _gameEngine;

        public BowlingGameTest()
        {
            _gameEngine = new BowlingGameEngine();
        }

        [Fact]
        public void AllGutterballs()
        {
            RollTheBall(20, 0);

            Assert.Equal(0, _gameEngine.Score());
        }

        [Fact]
        public void RollOnce()
        {
            _gameEngine.Roll(3);

            Assert.Equal(3, _gameEngine.Score());
        }

        [Fact]
        public void TwoRolls()
        {
            _gameEngine.Roll(3);
            _gameEngine.Roll(4);

            Assert.Equal(7, _gameEngine.Score());
        }

        [Fact]
        public void ThreeRolls()
        {
            _gameEngine.Roll(3);
            _gameEngine.Roll(4);
            _gameEngine.Roll(4);

            Assert.Equal(11, _gameEngine.Score());
        }

        [Fact]
        public void RollASpare()
        {
            _gameEngine.Roll(2);
            _gameEngine.Roll(8);
            _gameEngine.Roll(3);
            
            Assert.Equal(16, _gameEngine.Score());
        }

        [Fact]
        public void RollAStrike()
        {
            _gameEngine.Roll(10);
            _gameEngine.Roll(3);
            _gameEngine.Roll(2);
            
            Assert.Equal(20, _gameEngine.Score());
        }

        [Fact]
        public void RollATwoStrikes()
        {
            _gameEngine.Roll(10);
            _gameEngine.Roll(10);
            _gameEngine.Roll(3);
            _gameEngine.Roll(2);

            Assert.Equal(43, _gameEngine.Score());
        }

        [Fact]
        public void RollAPerfectGame()
        {
            RollTheBall(12, 10);

            Assert.Equal(300, _gameEngine.Score());
        }

        private void RollTheBall(int timesRolled, int pinsDown)
        {
            for (int i = 0; i < timesRolled; i++)
            {
                _gameEngine.Roll(pinsDown:pinsDown);
            }
        }

    }
}
