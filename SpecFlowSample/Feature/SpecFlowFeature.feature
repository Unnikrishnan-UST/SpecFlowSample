Feature: SpecFlowFeatureLoginVerification
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#@mytag
#Scenario: Add two numbers
#	Given the first number is 50
#	And the second number is 70
#	When the two numbers are added
#	Then the result should be 120

@LoginTest
Scenario Outline: Successfull Login
   Given I have the correct username <username> and password <password>
   When Iclick the submit button
   Then I will be taken to Home page
   Examples: 
   | username | password |
   | unni    |   unni78 |