using CSharpKatas;

namespace UnitTest;

public static class UnitTest1
{
    [Theory]
    [InlineData(78,20)]
    [InlineData(23,10)]
    [InlineData(9168,200)]
    [InlineData(0,0)]
    public static void ShouldCheckMultiples3An5(int expected, int number)
    {
        //given 10 as number
        // when calculating the multiples sum
        var multipliesSum = MultiplesOf3Or5.MultiplesOf3Or5Sum(number);
        // Should return 23
        Assert.Equal(expected, multipliesSum);
    }
}