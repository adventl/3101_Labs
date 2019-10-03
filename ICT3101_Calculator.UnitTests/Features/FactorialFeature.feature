Feature: FactorialFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Factorial
Scenario Outline: Factorial a number
	Given I have a calculator
	When I press "<value1>" and press factorial
	Then the factorial result should be "<value2>" on the screen
	Examples:
	|value1 |value2 |
	|1		|1		|
	|2		|2		|
	|3		|6		|
	|4		|24		|
