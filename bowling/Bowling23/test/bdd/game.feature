Feature: Bowling Game
  As a bored teenager on a Friday night
  I want to go bowling
  So I can hang out with my friends


  Scenario: Bowl All Gutterballs
    Given a new Bowling Game
    When I roll all gutterballs
    Then my score is 0

  Scenario: Bowl All Strikes
    Given a new Bowling Game
    When I roll all strikes
    Then my score is 300

