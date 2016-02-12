/**
 * Created by dxstarr on 2/11/2016.
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

            if(isStrike(rollCounter)) {
                score += scoreStrike(rollCounter);
                rollCounter += 1;
            }
            else if (isSpare(rollCounter)) {
                score += scoreSpare(rollCounter);
                rollCounter += 2;
            } else {
                score += scoreStandardFrame(rollCounter);
                rollCounter += 2;
            }
        }
        return score;
    }

    private int scoreStrike(int rollCounter) {
        return 10 + rolls[rollCounter+1] + rolls[rollCounter+2];
    }

    private int scoreSpare(int rollCounter) {
        return 10 + rolls[rollCounter + 2];
    }

    private int scoreStandardFrame(int rollCounter) {
        return rolls[rollCounter] + rolls[rollCounter + 1];
    }

    private boolean isStrike(int roll) {
        return rolls[roll] == 10;
    }

    private boolean isSpare(int roll) {
        return rolls[roll] + rolls[roll + 1] == 10;
    }
}
