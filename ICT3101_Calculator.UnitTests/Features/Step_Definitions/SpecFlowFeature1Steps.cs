using ICT3101_Lab1;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features.Step_Definitions
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Calculator _calculator;
        private double _result;
        public SpecFlowFeature1Steps(Calculator calc)
        {
            this._calculator = calc;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add II")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAddII(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result should be ""(.*)"" II")]
        public void ThenTheResultShouldBeII(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
             

    }
}
