using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bowling04
{
    public class GameTests
    {
        private Game _game;

        public GameTests()
        {
            _game = new Game();
        }

        [Fact]
        public void Rolling_all_gutterballs()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(0);
            }
            Assert.Equal(0, _game.GetScore());
        }
    
        [Fact]
        public void Rolling_all_1s()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(1);
            }
            Assert.Equal(20, _game.GetScore());
        }

        [Fact]
        public void Rolling_a_Spare()
        {
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(3);

            Assert.Equal(16, _game.GetScore());
        }

        [Fact]
        public void Rolling_a_Strike()
        {
            _game.Roll(10);
            _game.Roll(7);
            _game.Roll(2);

            Assert.Equal(28, _game.GetScore());
        }

        [Fact]
        public void Perfect_game_strike_bonus()
        {
            for (int i = 0; i < 12; i++)
            {
                _game.Roll(10);
            }
            Assert.Equal(300, _game.GetScore());
        }
    }
}
