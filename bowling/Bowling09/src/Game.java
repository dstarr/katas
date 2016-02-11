public class Game {

    int[] rolls = new int[21];
    int rollIndex = 0;

    public void roll(int pinsDown) {
        rolls[rollIndex++] = pinsDown;
    }

    public int getScore() {

        int score = 0;
        int frameIndex = 0;

        for (int i = 0; frameIndex < 10; frameIndex++) {

            if(isStrike(rolls[i])) {
                score += strikeBonus(i);
                i++;
            }
            else if(isSpare(i)) {
                score += spareBonus(i);
                i += 2;
            }
            else {
                score += standardFrame(i);
                i += 2;
            }
        }

        return score;
    }

    private int standardFrame(int i) {
        return rolls[i] + rolls[i+1];
    }

    private int strikeBonus(int i) {
        return 10 + rolls[i+1] + rolls[i+2];
    }

    private int spareBonus(int i) {
        return 10 + rolls[i+2];
    }

    private boolean isSpare(int i) {
        return rolls[i] + rolls[i+1] == 10;
    }

    private boolean isStrike(int roll) {
        return roll == 10;
    }
}
