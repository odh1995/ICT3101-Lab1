using ICT3101_Lab1;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press CurrentFailureIntensity")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressCurrentFailureIntensity(double p0, double p1, double p2)
        {
            _result = _calculator.CurrentFailureIntensity(p0, p1, p2);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" and ""(.*)"" into the calculator and press AvaerageExpectedFailures")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressAvaerageExpectedFailures(double p0, double p1, double p2)
        {
            _result = _calculator.AverageNumberofExpectedFailure(p0, p1, p2);
        }

        [Then(@"the current failure intensity should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered intensityDecay = ""(.*)"" and initial = ""(.*)"" and avgFail = ""(.*)"" into the calculator and press CurrentFailureIntensity in LOG model")]
        public void WhenIHaveEnteredIntensityDecayAndInitialAndAvgFailIntoTheCalculatorAndPressCurrentFailureIntensityInLOGModel(double p0, double p1, double p2)
        {
            _result = _calculator.CurrentFailureIntensityInLOG(p0, p1, p2);
        }

        [When(@"I have entered intensityDecay = ""(.*)"" and initial = ""(.*)"" and time = ""(.*)"" into the calculator and press NumberofExpectedFailureAfterTimeInLOG in LOG model")]
        public void WhenIHaveEnteredIntensityDecayAndInitialAndTimeIntoTheCalculatorAndPressNumberofExpectedFailureAfterTimeInLOGInLOGModel(double p0, double p1, double p2)
        {
            _result = _calculator.NumberofExpectedFailureAfterTimeInLOG(p0, p1, p2);
        }

        [Then(@"the current failure intensity in LOG should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityInLOGShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }


    }
}
