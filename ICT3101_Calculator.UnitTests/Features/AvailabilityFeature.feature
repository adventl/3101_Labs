Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this

@Availability
Scenario Outline: Calculating MTBF
	Given I have a calculator
	When I have entered "<mttf>" and "<mttr>" into the calculator and press MTBF
	Then the mtbf result should be "<mtbf>"
	Examples:
	|mttf	|mttr	|mtbf	|
	|100	|20		|120	|
	|100	|200	|300	|
	|111	|222	|333	|

@Availability
Scenario Outline: Calculating Availability
	 Given I have a calculator
	 When I have entered "<mttf>" and "<mtbf>" into the calculator and press Availability
	 Then the availability result should be "<availability>"
	Examples:
	|mttf	|mtbf	|availability	|
	|100	|200	|0.5			|
	|100	|400	|0.25			|
	|100	|800	|0.125			|
	|0		|800	|0				|

