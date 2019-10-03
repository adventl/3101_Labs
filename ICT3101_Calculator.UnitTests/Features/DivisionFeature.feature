Feature: DivisionFeature
			In order to conquer divisions
			As a division enthusiast
			I want to understand a variety of division operations

@Division
Scenario: Divide two numbers Test
	Given I have a calculator
	When I have entered "100" and "50" into the calculator and press divide
	Then the division result should be "2" on the screen

@Division
Scenario Outline: Dividing two numbers
	Given I have a calculator
	When I have entered "<value1>" and "<value2>" into the calculator and press divide
	Then the division result should be "<value3>" on the screen
	Examples:
	|value1 |value2 |value3 |
	|1		|2		|0.5	|
	|0		|15		|0		|
	|0		|0		|1		|

