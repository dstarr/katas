using Bowling;

namespace BowlingSpecs
{
    public class GameTestBase
    {
        protected Game Game { get; set; }

        public GameTestBase()
        {
            Game = new Game();
        }
    }
}