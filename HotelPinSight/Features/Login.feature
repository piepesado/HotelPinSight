Feature: Login
	As Agency level pinSight user,
	I woudld like to be able to log into the pinSight platform.

@login
Scenario: Login as Agency user
	Given Given that I navigate to the pinSight application
	And And I enter testuser@mailinator.com as the username
	And I enter password as password	
	When I press login
	Then I should land on the Hotel page
