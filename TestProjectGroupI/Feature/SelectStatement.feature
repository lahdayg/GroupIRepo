Feature: SelectStatement
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Selecting from Dropdown
	Given I navigate to the "http://demo.automationtesting.in/Register.html"
	And I select any skills from the dropdown
	And I want to confirm my PR as been created
	When the two numbers are added
	Then the result should be 120