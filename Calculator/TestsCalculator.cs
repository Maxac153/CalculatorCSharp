using Xunit;

public class TestsCalculator {
    [Theory]
    [InlineData('/', 10, 5, 2)]
    [InlineData('/', 10, 0, 0)]
    [InlineData('/', 2, 5, 0.4)]
    public void DivisionTest(char operation, double number_one, double number_two, double ExpectedResult) {
        Assert.Equal(ExpectedResult, Calculator.Calc(operation, number_one, number_two));
    }

    [Theory]
    [InlineData('*', 10, 5, 50)]
    public void MultiplicationTest(char operation, double number_one, double number_two, double ExpectedResult) {
        Assert.Equal(ExpectedResult, Calculator.Calc(operation, number_one, number_two));
    }

    [Theory]
    [InlineData('+', 10, 5, 15)]
    [InlineData('+', -10, 5, -5)]
    public void AddTest(char operation, double number_one, double number_two, double ExpectedResult) {
        Assert.Equal(ExpectedResult, Calculator.Calc(operation, number_one, number_two));
    }

    [Theory]
    [InlineData('-', 10, 5, 5)]
    [InlineData('-', 5, 10, -5)]
    public void SubtractionTest(char operation, double number_one, double number_two, double ExpectedResult) {
        Assert.Equal(ExpectedResult, Calculator.Calc(operation, number_one, number_two));
    }
}