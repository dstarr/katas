import com.godaddy.Game.Game;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by dxstarr on 5/16/2016.
 */
public class GameTest {

    private Game game;

    @Before
    public void setUp() throws Exception {

        game = new Game();
    }

    @Test
    public void allGutterBalls() {

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

        game.roll(7);
        game.roll(3);
        game.roll(4);

        assertEquals(18, game.getScore());
    }

    @Test
    public void rollStrike() {

        game.roll(10);
        game.roll(3);
        game.roll(2);

        assertEquals(20, game.getScore());
    }

    @Test
    public void perfectGame() {

        rollManyTimes(10, 12);
    }

    private void rollManyTimes(int pinsDown, int timesRolled) {

        for (int i = 0; i < timesRolled; i++) {
            game.roll(pinsDown);
        }
    }

}

