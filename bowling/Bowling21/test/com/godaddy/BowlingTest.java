package com.godaddy;

import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 * Created by dxstarr on 4/27/2016.
 */
public class BowlingTest {

    private Game game;

    @Before
    public void setUp() throws Exception {

        game = new Game();
    }

    @Test
    public void allGutterBalls() {

        int pinsDown = 0;
        int timesRolled = 20;

        rollManyTimes(pinsDown, timesRolled);

        assertEquals(0, game.getScore());
    }

    @Test
    public void allAllOnes() {

        int pinsDown = 1;
        int timesRolled = 20;

        rollManyTimes(pinsDown, timesRolled);

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
        game.roll(6);

        assertEquals(28, game.getScore());
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
