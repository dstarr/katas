import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

/**
 * Created by dxstarr on 2/11/2016.
 */
public class GameSpecs {

    private Game game;

    @Before
    public void setUp() throws Exception {
        game = new Game();
    }

    @Test
    public void allGutterballs() {

        rollManyTimes(0, 20);

        Assert.assertEquals(0, game.getScore());
    }

    @Test
    public void allOnes() {

        rollManyTimes(1, 20);

        Assert.assertEquals(20, game.getScore());
    }

    @Test
    public void rollSpare() {
        game.roll(5);
        game.roll(5);
        game.roll(3);

        Assert.assertEquals(16, game.getScore());
    }

    @Test
    public void rollStrike() {
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
