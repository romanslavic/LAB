namespace UnitTesting;

public static class CustomMath
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        
        return a / b;
    }

    public static bool IsDivisible(int a, int b)
    {
        return a % b == 0;
    }
}
