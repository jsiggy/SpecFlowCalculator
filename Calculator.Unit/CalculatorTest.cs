namespace Calculator.Test;

public class CalculatorTest
{
    [Fact]
    public void ShouldAddTwoNumbers()
    {
        var calculator = new Calculator();
        calculator.FirstNumber = 5;
        calculator.SecondNumber = 10;
        
        var result = calculator.Add();
        
        Assert.Equal(15, result);
    }
}