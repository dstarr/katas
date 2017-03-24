import com.Game;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class GameTest {

    private Game game;

    @Before
    public void setUp() throws Exception {

        game = new Game();
    }

    @Test
    public void rollAllGutterballs() {

        int timesRolled = 20;
        int pinsDown = 0;

        rollManyTime(pinsDown, timesRolled);

        assertEquals(0, game.getScore());
    }

    @Test
    public void rollAllOnes() {

        int timesRolled = 20;
        int pinsDown = 1;

        rollManyTime(pinsDown, timesRolled);

        assertEquals(20, game.getScore());
    }

    @Test
    public void rollSpare() {
        game.roll(7);
        game.roll(3);
        game.roll(6);

        assertEquals(22, game.getScore());

    }

    @Test
    public void rollStrike() {
        game.roll(10);
        game.roll(3);
        game.roll(4);

        assertEquals(24, game.getScore());

    }

    @Test
    public void aPerfectGame() {
        rollManyTime(10, 12);

        assertEquals(300, game.getScore());
    }

    @Test
    public void iDontBelieveYou() {
        game.roll(10);
        game.roll(10);
        game.roll(3);


        assertEquals(39, game.getScore());
    }

    private void rollManyTime(int pinsDown, int timesRolled) {

        for (int i = 0; i < timesRolled; i++) {
            game.roll(pinsDown);
        }
    }

}
