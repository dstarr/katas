/**
 * Created by dxstarr on 3/1/2016.
 */
public class Game {

    int[] rolls = new int[21];
    int rollCount = 0;

    public void roll(int pinsDown) {
        rolls[rollCount++] = pinsDown;

    }

    public int getScore() {
        int score = 0;
        int rollIndex = 0;

        for (int frameIndex = 0; frameIndex < 10; frameIndex++) {

            if(isStrike(rollIndex)) {
                score += scoreStrike(rollIndex);
                rollIndex += 1;
            }
            else if(isSpare(rollIndex)) {
                score += scoreSpare(rollIndex);
                rollIndex += 2;
            }
            else {
                score += scoreStandardFrame(rollIndex);
                rollIndex += 2;
            }
        }

        return score;
    }

    private int scoreStrike(int rollIndex) {
        return 10 + rolls[rollIndex+1] + rolls[rollIndex+2];
    }

    private int scoreSpare(int rollIndex) {
        return 10 + rolls[rollIndex+2];
    }

    private int scoreStandardFrame(int rollIndex) {
        return rolls[rollIndex] + rolls[rollIndex + 1];
    }

    private boolean isStrike(int rollIndex) {
        return rolls[rollIndex] == 10;
    }

    private boolean isSpare(int rollIndex) {
        return rolls[rollIndex] + rolls[rollIndex+1] == 10;
    }
}
