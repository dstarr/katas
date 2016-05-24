package Game;

/**
 * Created by dxstarr on 5/24/2016.
 */
public class Game {

    int[] rolls = new int[21];
    int rollIndex = 0;

    public void roll(int pinsDown) {

        rolls[rollIndex++] = pinsDown;
    }

    public int getScore() {

        int score = 0;
        int rollCounter = 0;

        for (int frameIndex = 0; frameIndex < 10; frameIndex++) {

            if(isStrike(rolls[rollCounter])) {
                score += getStrikeScore(rollCounter);
                rollCounter += 1;
            } else if (isSpare(rollCounter)) {
                score += getSpareBonus(rollCounter);
                rollCounter += 2;
            } else {
                score += getStandardFrameScore(rollCounter);
                rollCounter += 2;
            }
        }

        return score;
    }

    private boolean isStrike(int roll) {

        return roll == 10;
    }

    private int getStrikeScore(int rollCounter) {

        return rolls[rollCounter] + rolls[rollCounter+1] + rolls[rollCounter+2];
    }

    private int getStandardFrameScore(int rollCounter) {

        return rolls[rollCounter] + rolls[rollCounter + 1];
    }

    private int getSpareBonus(int rollCounter) {

        return rolls[rollCounter] + rolls[rollCounter + 1] + rolls[rollCounter + 2];
    }

    private boolean isSpare(int rollCounter) {

        return rolls[rollCounter] + rolls[rollCounter + 1] == 10;
    }
}
