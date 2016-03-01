/**
 * Created by dxstarr on 2/29/2016.
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

            if(isStrike(rolls[rollCount])) {
                score += addStikeBonus(rollCount);
                rollCount += 1;
            }
            else if(isSpare(rollCount)) {
                score += addSpareBonus(rollCount);
                rollCount += 2;
            }
            else {
                score += addStandardFrame(rollCount);
                rollCount += 2;
            }
        }

        return score;
    }

    private int addStandardFrame(int rollCount) {
        return rolls[rollCount] + rolls[rollCount + 1];
    }

    private int addSpareBonus(int rollCount) {
        return 10 + rolls[rollCount+2];
    }

    private boolean isSpare(int rollCount) {
        return rolls[rollCount] + rolls[rollCount+1]== 10;
    }

    private int addStikeBonus(int rollCount) {
        return 10 + rolls[rollCount+1] + rolls[rollCount+2];
    }

    private boolean isStrike(int roll) {
        return roll == 10;
    }
}
