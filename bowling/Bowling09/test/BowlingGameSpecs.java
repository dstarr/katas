import org.junit.Before;
import org.junit.Test;

import static junit.framework.Assert.assertEquals;

public class BowlingGameSpecs {

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
        game.roll(2);
        game.roll(3);

        assertEquals(20, game.getScore());
    }

    @Test
    public void perfectGame() {
        rollManyTimes(10, 12);
        assertEquals(300, game.getScore());
    }

    private void rollManyTimes(int pinsDown, int timesRolled) {
        for (int i = 0; i < timesRolled; i++) {
            game.roll(pinsDown);
        }
    }


}
