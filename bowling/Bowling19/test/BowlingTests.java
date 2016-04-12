import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by dxstarr on 4/11/2016.
 */
public class BowlingTests {

    private Game game;

    @Before
    public void setUp() throws Exception {

        game = new Game();
    }

    @Test
    public void allGutterballs() {

        int timesRolled = 20;
        int pinsDown = 0;

        rollManyTimes(pinsDown, timesRolled);

        assertEquals(0, game.getScore());
    }

    @Test
    public void allOnes() {

        rollManyTimes(1, 20);

        assertEquals(20, game.getScore());
    }

    @Test
    public void rollSpare() {
        game.roll(3);
        game.roll(7);
        game.roll(3);

        assertEquals(16, game.getScore());
    }

    @Test
    public void rollStrike() {
        game.roll(10);
        game.roll(3);
        game.roll(3);

        assertEquals(22, game.getScore());
    }

    private void rollManyTimes(int pinsDown, int timesRolled) {

        for (int i = 0; i < timesRolled; i++) {
            game.roll(pinsDown);
        }
    }

}
