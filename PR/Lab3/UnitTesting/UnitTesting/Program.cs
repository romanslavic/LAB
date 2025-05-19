using UnitTesting;

if (CustomMath.Sum(1, 3) == 4)
{
    Console.WriteLine("Test1 passed");
}
else
{
    Console.WriteLine("Test1 failed");
}

try
{
    CustomMath.Divide(1, 0);
    Console.WriteLine("Test2 failed");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Test2 passed");
}
