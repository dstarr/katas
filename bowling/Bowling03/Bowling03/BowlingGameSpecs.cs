using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Should;

namespace Bowling03
{
    public class BowlingGameSpecs
    {
        private Game _game;

        public BowlingGameSpecs()
        {
            _game = new Game();
            
        }

        [Fact]
        public void All_gutterballs_scores_0()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(0);
            }
            _game.GetScore().ShouldBe(0);
        }

        [Fact]
        public void All_ones_scores_20()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(1);
            }
            _game.GetScore().ShouldBe(20);
        }

        [Fact]
        public void Spare_gets_a_spare_bonus()
        {
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(6);
            _game.GetScore().ShouldBe(22);
        }

        [Fact]
        public void Strike_gets_strike_bonus()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(7);
            _game.GetScore().ShouldBe(27);
        }
    }
}
