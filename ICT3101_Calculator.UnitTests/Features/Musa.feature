Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@MUSA
Scenario: Calculating the current failure intensity
	Given I have a calculator
	When I have entered "33" and "150" and "450" into the calculator and press CurrentFailureIntensity
	Then the current failure intensity should be "22"

@MUSA
Scenario: Calculating the average number of expected failures
	Given I have a calculator
	When I have entered "450" and "33" and "5" into the calculator and press AvaerageExpectedFailures
	Then the current failure intensity should be "138"

@MUSA_LOG
Scenario: Calculating the current failure intensity using MUSA LOG
	Given I have a calculator
	When I have entered intensityDecay = "0.02" and initial = "10" and avgFail = "50" into the calculator and press CurrentFailureIntensity in LOG model
	Then the current failure intensity in LOG should be "3.68"

@MUSA_LOG
Scenario: Calculating the number of expected failures after t hours using MUSA LOG
	Given I have a calculator
	When I have entered intensityDecay = "0.02" and initial = "10" and time = "100" into the calculator and press NumberofExpectedFailureAfterTimeInLOG in LOG model
	Then the current failure intensity in LOG should be "152"
