package bdd;

//import com.Game;
//import cucumber.api.java.en.Given;
//import cucumber.api.java.en.Then;
//import cucumber.api.java.en.When;
//import org.junit.Assert;

/**
 * Created by dxstarr on 3/24/17.
 */
//public class MyStepdefsBackup {
//
//    private Game game;
//
//    @Given("^a new Bowling Game$")
//    public void aNewBowlingGame() throws Throwable {
//
//        game = new Game();
//    }
//
//
//    @When("^I roll all gutterballs$")
//    public void iRollAllGutterballs() throws Throwable {
//
//        for (int i = 0; i < 21; i++) {
//            game.roll(0);
//        };
//    }
//
//    @Then("^my score is (\\d+)$")
//    public void myScoreIs(int score) throws Throwable {
//        Assert.assertEquals(score, game.getScore());
//    }
//
//    @When("^I roll all strikes$")
//    public void iRollAllStrikes() throws Throwable {
//        for (int i = 0; i < 21; i++) {
//            game.roll(10);
//        }
//    }
//}