class game:

	
	def __init__(self):
		self.rolls = []
		
	def roll(self, pinsDown):
		self.rolls.append(pinsDown)

	def getScore(self):
		
		result = 0;
		rollIndex = 0;

		for frameIndex in range(10):
			
			if self.isStrike(rollIndex):
				result += self.scoreStrikeFrame(rollIndex)
				rollIndex += 1
				pass

			elif (self.isSpare(rollIndex)):
				result += self.scoreSpareFrame(rollIndex)
				rollIndex += 2
				pass
			else:
				result += self.scoreStandardFrame(rollIndex)
				rollIndex += 2
				pass

			
		
		return result

	def scoreStrikeFrame(self, rollIndex):
		return 10 + self.rolls[rollIndex + 1] + self.rolls[rollIndex + 2];

	def scoreSpareFrame(self, rollIndex):
		return 10 + self.rolls[rollIndex + 2]

	def scoreStandardFrame(self, rollIndex):
		return self.rolls[rollIndex] + self.rolls[rollIndex + 1];


	def isSpare(self, rollIndex):
		if(self.rolls[rollIndex] + self.rolls[rollIndex + 1] == 10):
			return True

	def isStrike(self, rollIndex):
		if self.rolls[rollIndex] == 10:
			return True

