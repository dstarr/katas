using Xunit;

namespace BowlingSpecs
{
    public class When_rolling_all_strikes : GameTestBase
    {
        [Fact]
        public void Then_score_is_300()
        {
            for (int i = 0; i < 12; i++)
            {
                Game.Roll(10);
            }
            Assert.Equal(300, Game.GetScore());
        }
    }
}