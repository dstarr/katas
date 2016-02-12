import org.junit.Before;
import org.junit.Test;

import static junit.framework.TestCase.assertEquals;

/**
 * Created by dxstarr on 2/11/2016.
 */
public class GameSpecs {

    private Game game;

    @Before
    public void beforeEachTest() {
        game = new Game();
    }

    @Test
    public void allGutterballs() {

        rollManyTimes(0, 20);

        assertEquals(0, game.getScore());
    }

    @Test
    public void allOnes() {

        rollManyTimes(1, 20);

        assertEquals(20, game.getScore());
    }

    @Test
    public void rollSpare() {
        game.roll(5);
        game.roll(5);
        game.roll(3);

        assertEquals(16, game.getScore());
    }

    @Test
    public void rollStrike() {
        game.roll(10);
        game.roll(5);
        game.roll(3);

        assertEquals(26, game.getScore());
    }

    @Test
    public void perfectGame() {
        rollManyTimes(10, 12);
        assertEquals(300, game.getScore());
    }

    private void rollManyTimes(int pinsDown, int timedRolled) {
        for (int i = 0; i < timedRolled; i++) {
            game.roll(pinsDown);
        }
    }

}
