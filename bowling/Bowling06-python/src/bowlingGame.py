class game:

    
    def __init__(self):
        self.rolls = []

    def roll(self, pinsDown):
        self.rolls.append(pinsDown)
        
    def getScore(self):
        score = 0
        rollIndex = 0
        
        for frameIndex in range(10):
            
            if (self.rolls[rollIndex] == 10):
                score += 10 + self.rolls[rollIndex + 1] + self.rolls[rollIndex + 2]
                rollIndex += 1  
            
            elif (self.rolls[rollIndex] + self.rolls[rollIndex + 1] == 10):
                score += 10 + self.rolls[rollIndex + 2]
                rollIndex += 2
        
            else:
                score += self.rolls[rollIndex] + self.rolls[rollIndex + 1]
                rollIndex += 2

        return score