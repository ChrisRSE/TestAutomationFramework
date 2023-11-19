Feature: Validates user login and navigation functionality 

Scenario: Successful login when logging in with a standard user
	Given I am on the login page
	When I enter username "standard_user" and password "secret_sauce"
	And I click the login button
	Then I should be navigated to the product page

Scenario: Unsuccessful login when logging in with an invalid username and password
	Given I am on the login page
	When I enter username "invalid" and password "invalid"
	And I click the login button
	Then an error message will be displayed containing "Username and password do not match any user in this service"

Scenario: Unsuccessful login when logging in with a locked out user
	Given I am on the login page
	When I enter username "locked_out_user" and password "secret_sauce"
	And I click the login button
	Then an error message will be displayed containing "Sorry, this user has been locked out"

Scenario: Validate error messages for empty username and password fields
	Given I am on the login page
	When I enter username <username> and password <password>
	And I click the login button
	Then an error message will be displayed containing <error_message>
	Examples:
		| username | password | error_message		   |
		| ""       | "pass01" | "Username is required" |
		| "user01" | ""       | "Password is required" |
