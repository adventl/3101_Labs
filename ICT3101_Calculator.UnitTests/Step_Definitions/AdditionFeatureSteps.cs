using System;
using NUnit.Framework;
using Program;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class AdditionFeatureSteps
    {
        private Calculator _calculator;

        public AdditionFeatureSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        private double _result;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            Assert.That(_calculator, Is.Not.Null);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the addition result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}