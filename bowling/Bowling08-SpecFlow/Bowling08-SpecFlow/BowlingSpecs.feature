Feature: BowlingSpecs
	In order to know my score
	As a bowler
	I want to score a bowling game

@mytag
Scenario: All gutterballs
	Given I have rolled all gutterballs
	When I get the score
	Then the score should be 0

Scenario: All 1s
	Given I have rolled all ones
	When I get the score
	Then the score should be 20

Scenario: Rolled a spare
	Given I have rolled a spare
	When I get the score
	Then the score should be 16

Scenario: Rolled a strike
	Given I have rolled a strike
	When I get the score
	Then the score should be 22

Scenario: Perfect game
	Given I have rolled all strikes
	When I get the score
	Then the score should be 300


