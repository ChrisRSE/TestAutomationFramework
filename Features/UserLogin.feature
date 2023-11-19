Feature: Validates user login and navigation functionality 

Scenario: Successful login when logging in with a standard user
	Given I am on the login page
	When I enter username "standard_user" and password "secret_sauce"
	And I click the login button
	Then I should be navigated to the product page

Scenario: Unsuccessful login with logging in with a locked out user
	Given I am on the login page
	When I enter username "locked_out_user" and password "secret_sauce"
	And I click the login button
	Then an error message will be displayed containing "Sorry, this user has been locked out"