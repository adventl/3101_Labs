using System;
using NUnit.Framework;
using Program;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class DivisionFeatureSteps
    {
        private Calculator _calculator;

        public DivisionFeatureSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        private double _result;

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be ""(.*)"" on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}