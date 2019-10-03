Feature:  UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@BasicReilability
Scenario Outline: Calculate Basic Reliability
	Given I have a calculator
	When I enter the "<initialFailure>", "<currentFailure>", and "<totalFailures>" and press current failure intensity
	Then the current failure intensity should be "<currentFailureIntensity>"
	Examples:
	| initialFailure | currentFailure | totalFailures | currentFailureIntensity |
	| 10             | 50             | 100           | 5                       |
	| 20             | 50             | 100           | 10                      |
	
@BasicReilability
Scenario Outline: Calculate average number of expected failures
	Given I have a calculator
	When I enter the "<totalFailures>", "<initialFailure>", and "<time>" and press average number of expected failures
	Then the average number of expected failures should be "<expectedFailures>"
	Examples:
	| totalFailures | initialFailure | time | expectedFailures |
	| 100           | 10             | 10   | 63				|
