using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Bowling;
using Xunit;

namespace BowlingSpecs
{
    public class When_bowling_all_gutterballs : GameTestBase
    {
        [Fact]
        public void The_score_is_0()
        {
            for (int i = 0; i < 21; i++)
            {
                Game.Roll(0);
            }
            Assert.Equal(0, Game.GetScore());
        }
    }
}
