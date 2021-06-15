using System;
using TechTalk.SpecFlow;
using CalculatorProject;
using NUnit.Framework;
using System.Collections.Generic;

namespace CalculatorBDD
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        private Calculator _calculator;
        private int _result;
        private List<int> _numlist;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
        
        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int a, int b)
        {
            _calculator.Num1 = a;
            _calculator.Num2 = b;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result = _calculator.Subtract();
        }

        [When(@"I press muliply")]
        public void WhenIPressMuliply()
        {
            _result = _calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            _result = _calculator.Divide();
        }
        [Given(@"(.*) is equal to zero")]
        public void GivenIsEqualToZero(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter the numbers below to a list")]
        public void GivenIEnterTheNumberesBelowToAList(Table table)
        {
            _numlist = new List<int>();
            foreach (var row in table.Rows)
            {
                _numlist.Add(int.Parse(row[0]));
            }
        }

        [When(@"I iterate through the list to add all the even numbers")]
        public void WhenIIterateThroughTheListToAddAllTheEvenNumbers()
        {
            _calculator.SumOfEvenNums(_numlist);
        }


        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [Then(@"a DivideByZero Exception should be thrown with the exception message ""(.*)"" when I press divide")]
        public void ThenADivideByZeroExceptionShouldBeThrownWithTheExceptionMessageWhenIPressDivide(string expected)
        {
            Assert.That(() => _calculator.Divide(),
                             Throws.Exception.With.Message.EqualTo(expected));
        }
    }
}
