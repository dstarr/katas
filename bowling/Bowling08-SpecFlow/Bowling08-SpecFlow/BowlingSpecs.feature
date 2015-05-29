Feature: BowlingSpecs
	As a bowler
	ISBAT score a bowling game
	So that I can know my score


Scenario: All gutterballs
	Given I rolled all gutterballs
	When I get the score
	Then the score should be 0

Scenario: All 1s
	Given I rolled all ones
	When I get the score
	Then the score should be 20

Scenario: Rolled a spare
	Given I rolled a spare
	When I get the score
	Then the score should be 16

Scenario: Rolled a strike
	Given I rolled a strike
	When I get the score
	Then the score should be 22

Scenario: Perfect game
	Given I rolled all strikes
	When I get the score
	Then the score should be 300


