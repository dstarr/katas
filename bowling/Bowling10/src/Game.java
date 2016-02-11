public class Game {

    int[] rolls = new int[21];
    int rollIndex = 0;

    public void roll(int pinsDown) {
        rolls[rollIndex++] = pinsDown;
    }

    public int getScore() {

        int score = 0;
        int rollCounter= 0;

        for (int frameIndex = 0; frameIndex < 10; frameIndex++) {

            if(currentFrameIsStrike(rolls[rollCounter])) {
                score += getStrikeFrameScore(rollCounter);
                rollCounter++;
            }
            else if(currentFrameIsSpare(rollCounter)) {
                score += getSpareFrameScore(rollCounter);
                rollCounter += 2;
            }
            else {
                score += getStandardFrameScore(rollCounter);
                rollCounter += 2;
            }
        }

        return score;
    }

    private boolean currentFrameIsSpare(int rollCounter) {
        return rolls[rollCounter] + rolls[rollCounter+1] == 10;
    }

    private boolean currentFrameIsStrike(int roll) {
        return roll == 10;
    }

    private int getStrikeFrameScore(int rollCounter) {
        return 10 + rolls[rollCounter +1] + rolls[rollCounter +2];
    }

    private int getStandardFrameScore(int rollCounter) {
        return rolls[rollCounter] + rolls[rollCounter + 1];
    }

    private int getSpareFrameScore(int rollCounter) {
        return 10 + rolls[rollCounter+2];
    }
}
