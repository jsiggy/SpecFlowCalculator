﻿using Xunit;

namespace Calculator.Specs.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly Calculator _calc = new();
    private int _result;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calc.FirstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calc.SecondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = _calc.Add();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int expectedResult)
    {
        Assert.Equal(expectedResult, _result);
    }
}