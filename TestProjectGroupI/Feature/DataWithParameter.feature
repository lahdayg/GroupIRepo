Feature: DataWithParameter
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Parameterization
	Given I navigate to the "https://angularjs.realworld.io/#/"
	And I click on sign up 
	And I enter my Username "FinidiGeorge"
	And I enter my email address "finidi"
	And I enter my password "PasswordSecure"
	When I click on the Sign up button
	Then I should be able to sign up successfully