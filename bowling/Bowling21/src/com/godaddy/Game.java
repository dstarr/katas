package com.godaddy;

/**
 * Created by dxstarr on 4/27/2016.
 */
public class Game {

    int[] rolls = new int[21];
    int rollIndex = 0;

    public void roll(int pinsDown) {
        rolls[rollIndex++] = pinsDown;
    }

    public int getScore() {

        int score = 0;
        int roll = 0;

        for (int frameIndex = 0; frameIndex < 10; frameIndex++) {

            if(isStrike(roll)) {
                score += scoreStrike(roll);
                roll += 1;
            }
            else  if(isSpare(roll)) {
                score += scoreSpare(roll);
                roll += 2;
            }
            else {
                score += scoreStandardFrame(roll);
                roll += 2;
            }
        }

        return score;
    }

    private int scoreStandardFrame(int roll) {

        return rolls[roll] + rolls[roll+1];
    }

    private int scoreSpare(int roll) {

        return 10 + rolls[roll+2];
    }

    private int scoreStrike(int roll) {

        return 10 + rolls[roll+1] + rolls[roll+2];
    }

    private boolean isSpare(int roll) {

        return rolls[roll] + rolls[roll+1] == 10;
    }

    private boolean isStrike(int roll) {

        return rolls[roll] == 10;
    }
}
