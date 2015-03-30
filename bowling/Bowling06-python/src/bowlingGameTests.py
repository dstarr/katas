import unittest
import bowlingGame
from builtins import range

class bowlingGameTests (unittest.TestCase):
    
    def setUp(self):
        self.game = bowlingGame.game()

    def testAllGutterballs(self):
        self.RollMany(0, 20)
        
        self.assertEqual(0, self.game.getScore())
            
    def testAllOnes(self):
        self.RollMany(1, 20)
        
        self.assertEqual(20, self.game.getScore())
        
    def testSpare(self):    
        self.game.roll(5)
        self.game.roll(5)
        self.game.roll(3)
        self.RollMany(0, 17)
        
        self.assertEqual(16, self.game.getScore())
            
    def testStrike(self):    
        self.game.roll(10)
        self.game.roll(2)
        self.game.roll(3)
        self.RollMany(0, 17)
        
        self.assertEqual(20, self.game.getScore())
        
    def testPerfectGame(self):
        self.RollMany(10, 12)
        self.assertEqual(300, self.game.getScore())
        
    def RollMany(self, pinsDown, timesToRoll):
        for i in range(timesToRoll):
            self.game.roll(pinsDown)
    
        
        



if __name__ == '__main__':
    unittest.main()