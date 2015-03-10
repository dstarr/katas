using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BowlingSpecs
{
    public class When_rolling_all_ones : GameTestBase
    {
        [Fact]
        public void Then_the_score_should_be_20()
        {
            for (int i = 0; i < 20; i++)
            {
                Game.Roll(1);
            }
            Assert.Equal(20, Game.GetScore());
        }
    }
}
