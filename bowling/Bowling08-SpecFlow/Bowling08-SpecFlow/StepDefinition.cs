using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Bowling08_SpecFlow
{
    [Binding]
    public class StepDefinitions
    {
        private Game _game;
        private int _score;


        [BeforeScenario()]
        public void BeforeScenario()
        {
            _game = new Game();
        }

        [Given(@"I have rolled all gutterballs")]
        public void GivenIHaveRolledAllGutterballs()
        {
            RollManyTimes(20, 0);
        }

        [Given(@"I have rolled all ones")]
        public void GivenIHaveRolledAllOnes()
        {
            RollManyTimes(20, 1);
        }

        [Given(@"I have rolled a spare")]
        public void GivenIHaveRolledASpareAndThenA()
        {
            _game.Roll(3);
            _game.Roll(7);
            _game.Roll(3);
            RollManyTimes(17, 0);
        }

        [Given(@"I have rolled a strike")]
        public void GivenIHaveRolledAStrike()
        {
            _game.Roll(10);
            _game.Roll(3);
            _game.Roll(3);
            RollManyTimes(17, 0);
        }

        [Given(@"I have rolled all strikes")]
        public void GivenIHaveRolledAllStrikes()
        {
            RollManyTimes(12, 10);
        }

        [When(@"I get the score")]
        public void WhenIGetTheScore()
        {
            _score = _game.GetScore();
        }

        [Then(@"the score should be (.*)")]
        public void ThenTheScoreShouldBe(int p0)
        {
            Assert.AreEqual(p0, _score);
        }
        
        private void RollManyTimes(int totalRolls, int pinsDown)
        {
            for (int i = 0; i < totalRolls; i++)
            {
                _game.Roll(pinsDown);
            }
        }
    }        
}
