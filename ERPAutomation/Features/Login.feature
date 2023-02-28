Feature: Login

Check if login functionality works

@utility-login
Scenario: Login user as Utitlity role user
	Given I navigate to application
	And I enter username and password
		| UserName		| Password	|
		| BREB_ADMIN	| 123456	|
	And I click login
	Then I should see user logged in to the application
