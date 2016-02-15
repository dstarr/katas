/**
 * Created by dxstarr on 2/15/2016.
 */
public class Game {

    int[] rolls = new int[21];
    int rollIndex = 0;

    public void roll(int pinsDown) {

        rolls[rollIndex++] = pinsDown;
    }

    public int getScore() {

        int score = 0;
        int rollCount = 0;

        for (int frameIndex = 0; frameIndex < 10; frameIndex++) {

            if(isStrike(rollCount)) {
                score += scoreStrike(rollCount);
                rollCount += 1;
            }
            else if(isSpare(rollCount)) {
                score += scoreSpare(rollCount);
                rollCount += 2;
            }
            else {
                score += scoreStandardFrame(rollCount);
                rollCount += 2;
            }
        }

        return score;
    }

    private boolean isStrike(int rollCount) {
        return rolls[rollCount] == 10;
    }

    private boolean isSpare(int rollCount) {
        return rolls[rollCount] + rolls[rollCount+1] == 10;
    }

    private int scoreStandardFrame(int rollCount) {
        return rolls[rollCount] + rolls[rollCount + 1];
    }

    private int scoreSpare(int rollCount) {
        return 10 + rolls[rollCount+2];
    }

    private int scoreStrike(int rollCount) {
        return 10 + rolls[rollCount+1] + rolls[rollCount+2];
    }
}
