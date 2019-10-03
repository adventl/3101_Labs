using System;
using NUnit.Framework;
using Program;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private Calculator _calculator;

        UsingCalculatorBasicReliabilitySteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        private double _result;

        [When(@"I enter the ""(.*)"", ""(.*)"", and ""(.*)"" and press current failure intensity")]
        public void WhenIEnterTheAndAndPressCurrentFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calculator.BasicReliability(p0, p1, p2);
        }

        [When(@"I enter the ""(.*)"", ""(.*)"", and ""(.*)"" and press average number of expected failures")]
        public void WhenIEnterTheAndAndPressAverageNumberOfExpectedFailures(int p0, int p1, int p2)
        {
            _result = (int) _calculator.BasicExpectedFailures(p0, p1, p2);
        }


        [Then(@"the current failure intensity should be ""(.*)""")]
        public void ThenTheCurrentFailureIntensityShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the average number of expected failures should be ""(.*)""")]
        public void ThenTheAverageNumberOfExpectedFailuresShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}