import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

public class GameSpec {

    private Game game;

    @Before
    public void beforeeAchTest() {
        game = new Game();
    }

    @Test
    public void allGutterBalls() {
        for (int i = 0; i < 20; i++) {
            game.roll(0);
        }

        Assert.assertEquals(0, game.getScore());
    }

    @Test
    public void allOnes() {

        for (int i = 0; i < 20; i++) {
            game.roll(1);
        }

        Assert.assertEquals(20, game.getScore());
    }

    @Test
    public void rollASpare() {
        game.roll(5);
        game.roll(5);
        game.roll(3);

        Assert.assertEquals(16, game.getScore());
    }

    @Test
    public void rollAStrike() {
        game.roll(10);
        game.roll(5);
        game.roll(3);

        Assert.assertEquals(26, game.getScore());
    }

    @Test
    public void perfectGame() {
        rollManyTimes(10, 12);

        Assert.assertEquals(300, game.getScore());
    }

    private void rollManyTimes(int pinsDown, int timesRolled) {
        for (int i = 0; i < timesRolled; i++) {
            game.roll(pinsDown);
        }
    }
}
