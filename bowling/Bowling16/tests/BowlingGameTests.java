import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;


/**
 * Created by dxstarr on 3/1/2016.
 */
public class BowlingGameTests {


    private Game game;

    @Before
    public void setUp() throws Exception {
        game = new Game();
    }

    @Test
    public void rollAllGutterballs() {

        int timesRolled = 20;
        int pinsDown = 0;

        rollManyTimes(pinsDown, timesRolled);

        assertEquals(0, game.getScore());
    }

    @Test
    public void rollAllOnes() {

        rollManyTimes(1, 20);

        assertEquals(20, game.getScore());
    }

    @Test
    public void rollASpare() {
        game.roll(5);
        game.roll(5);
        game.roll(3);

        assertEquals(16, game.getScore());
    }

    @Test
    public void rollAStrike() {
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

    private void rollManyTimes(int pinsDown, int timesRolled) {
        for (int i = 0; i < timesRolled; i++) {
            game.roll(pinsDown);
        }
    }


}
