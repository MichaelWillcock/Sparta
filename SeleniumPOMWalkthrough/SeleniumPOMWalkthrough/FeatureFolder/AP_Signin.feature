Feature: AP_Signin
	In order to be able to buy items
	As a registered user of the automation practice website
	I want to be able to sign in to my account

@login
Scenario: Invalid password - too short
	Given I am on the signin page
	And I have entered "testing@snailmail.com" in the email field
	And I have entered the <passwords>
	When I click the sign in button
	Then I should see an alert containing an error message "Invalid password."
	Examples: 
	| passwords |
	| four      |
	| 1234      |
	| nish      |

@login
Scenario: Invalid email
	Given I am on the signin page
	And I have entered "testingsnailmail.com" in the email field
	And I have entered the password {four}
	When I click the sign in button
	Then I should see an alert containing an error message "Invalid email address."
	
@google
@login
Scenario: Forgot password
	Given I am on the signin page
	When I click the forgot your password? link
	Then I will go to a form that will reset my password

@login
Scenario: Invalid email using specflow assist
	Given I am on the signin page
	And I have the following credentials:
	| email    | password |
	| test.com | nish     |
	When I enter these credentials
	And I click the sign in button
	Then I should see an alert containing an error message "Invalid email address."

@login
Scenario: Invalid email to create an account
	Given I am on the signin page
	And I have entered "NotAValidEmail" in the email field for create accout
	When I click the create account button
	Then After waiting for five seconds I should see an separate alert containing an error message "Invalid email address."

@login
Scenario: Valid email to create an account
	Given I am on the signin page
	And I have entered "testing150621@snailmail.com" into the email field for create account
	When I click the create account button
	Then After waiting for five seconds I should be taken to a new page to create an account

@login
@create
Scenario: No input fields entered
	Given I click register on the create account page
	Then After waiting for 10 seconds I should see eight alerts