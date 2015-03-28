import unittest
import bowlingGame

class TestBowlingGame(unittest.TestCase):

  def setUp(self):
    self.game = bowlingGame.game()

  def testingAllGutterballs(self):
    self.rollMany(0, 20)
    self.assertEqual(0, self.game.getScore())

  def testingAll1s(self):
    self.rollMany(1, 20)
    self.assertEqual(20, self.game.getScore())

  def testOneSpare(self):
    self.game.roll(9)
    self.game.roll(1)
    self.game.roll(3)
    self.rollMany(0, 17)
    self.assertEqual(16, self.game.getScore())

  def testOneStrike(self):
    self.game.roll(10)
    self.game.roll(1)
    self.game.roll(3)
    self.rollMany(0, 17)
    self.assertEqual(18, self.game.getScore())

  def testPefrectGame(self):
    self.rollMany(10, 21)
    self.assertEqual(300, self.game.getScore())

  def rollMany(self, pinsDown, rolls):
    for i in range(rolls):
      self.game.roll(pinsDown)



if __name__ == '__main__':
    unittest.main()