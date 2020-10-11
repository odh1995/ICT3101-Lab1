using ICT3101_Lab1;
using NUnit.Framework;
using System;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorDivisionsSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        
        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {            
            Assert.That(Double.IsInfinity(_result), Is.EqualTo(true));
        }       
        
    }
}
