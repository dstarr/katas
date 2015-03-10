using Xunit;

namespace BowlingSpecs
{
    public class When_rolling_one_spare_and_a_3 : GameTestBase
    {
        [Fact]
        public void Then_the_score_is_16()
        {
            Game.Roll(5);
            Game.Roll(5);
            Game.Roll(3);
            for (int i = 0; i < 17; i++)
            {
                Game.Roll(0);
            }
            Assert.Equal(16, Game.GetScore());
        }
    }
}