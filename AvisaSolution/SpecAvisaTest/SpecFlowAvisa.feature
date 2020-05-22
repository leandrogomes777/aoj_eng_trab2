Feature: AvisaUserRegister
	Users

@users
Scenario: Register a new User
	Given I have entered "Leandro" into the username
	And I have entered "Gomes" into the lastname
	And I have entered "Gomes" into the lastname
	And I have entered "123456" into the password
	When I press add
	Then the result should be "user successfully registered" 

@users
Scenario: Delete a User
	Given I have entered "Leandro" into the username
	And I have entered "Gomes" into the lastname
	And I have entered "Gomes" into the lastname
	And I have entered "123456" into the password
	When I press add
	Then the result should be "user successfully deleted" 