Feature: TwitterScenarios
	

@mytag
	Scenario: Navigate to Application
	Given Navigate to application using the URL
	Then application login screen should be displayed.

@mytag
	Scenario: Signup for Twitter
	Given Navigate to application using the URL
	Then application login screen should be displayed.
	Then Click Sign up for Twitter 
@mytag
	Scenario: Log into Twitter and post a Tweet
	Given Navigate to application using the URL
	Then application login screen should be displayed.
	Then Log into the application
	Then Post a Tweet
	Then Verify posted Tweet in Profile.


