using System;
using NUnit.Framework;
using Program;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class FactorialFeatureSteps
    {
        private Calculator _calculator;

        public FactorialFeatureSteps(Calculator calculator)
        {
            _calculator = calculator;
        }

        private int _result;

        [When(@"I press ""(.*)"" and press factorial")]
        public void WhenIPressAndPressFactorial(int p0)
        {
            _result = _calculator.Factorial_Recursion(p0);
        }

        [Then(@"the factorial result should be ""(.*)"" on the screen")]
        public void ThenTheFactorialResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}