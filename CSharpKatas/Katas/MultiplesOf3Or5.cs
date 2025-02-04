namespace CSharpKatas;

public static class MultiplesOf3Or5
{
    public static int MultiplesOf3Or5Sum(int number)
    => number < 0 ? 0: Enumerable
        .Range(0, number)
        .Where(num => num % 3 == 0 ||  num % 5 == 0 )
        .Sum();
}