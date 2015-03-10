using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Should;

namespace Bowling02
{
    public class GameTests
    {
        private readonly Game _game;

        public GameTests()
        {
            _game = new Game();
        }

        [Fact]
        public void Roll_all_gutterballs()
        {
            RollGutterballs(20);
            _game.GetScore().ShouldBe(0);
        }

        [Fact]
        public void Roll_all_ones()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(1);
            }
            _game.GetScore().ShouldBe(20);   
        }

        [Fact]
        public void Roll_a_spare()
        {
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(3);
            RollGutterballs(17);
            _game.GetScore().ShouldBe(16);
        }

        [Fact]
        public void Roll_a_strike()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(2);
            RollGutterballs(17);
            _game.GetScore().ShouldBe(20);
        }

        private void RollGutterballs(int numberToRoll)
        {
            for (int i = 0; i < numberToRoll; i++)
            {
                _game.Roll(0);
            }
        }


    }
}
