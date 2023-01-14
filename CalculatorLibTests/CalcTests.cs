using CalculatorLib;

namespace CalculatorLibTests;

public class CalcTests
{
    [Fact]
    public void Add_When2Integers_ShouldReturnCorrectInteger()
    {
        Calc calc = new Calc();
        int result = calc.Add(1,1);
        Assert.Equal(2, result);
        Assert.NotNull(result);
    }
}