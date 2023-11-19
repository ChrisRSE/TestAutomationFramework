Feature: Validates user login and navigation functionality 

Scenario: Successful login with a standard user
	Given I am on the login page
	When I enter username "standard_user" and password "secret_sauce"
	And I click the login button
	Then I should be navigated to the product page