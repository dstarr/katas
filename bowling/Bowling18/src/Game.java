/**
 * Created by dxstarr on 3/29/2016.
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
            else if(isSpare(rollCounter)) {
                score += scoreASpare(rollCounter);
                rollCounter += 2;
            }
            else {
                score += scoreStandardFrame(rollCounter);
                rollCounter += 2;
            }
        }

        return score;
    }

    private int scoreStrike(int rollCounter) {
        return 10 + rolls[rollCounter + 1] + rolls[rollCounter+2];
    }

    private boolean isStrike(int rollCounter) {
        return rolls[rollCounter] == 10;
    }

    private int scoreStandardFrame(int rollCounter) {
        return rolls[rollCounter] + rolls[rollCounter + 1];
    }

    private int scoreASpare(int rollCounter) {
        return 10 + rolls[rollCounter+2];
    }

    private boolean isSpare(int rollCounter) {
        return rolls[rollCounter] + rolls[rollCounter+1] == 10;
    }
}
