using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace UnitTesting;

[TestFixture]
public class CustomMathTest
{
    [Test]
    public void TestSum()
    {
        int result = CustomMath.Sum(10, 20);
        ClassicAssert.AreEqual(30, result);
    }

    [TestCase(10, 2, 5)]
    [TestCase(15, 3, 5)]
    [TestCase(20, 4, 5)]
    public void TestDivision_ValidValues(int x, int y, int expectedResult)
    {
        int result = CustomMath.Divide(x, y);

        ClassicAssert.AreEqual(expectedResult, result);
    }
    
    [TestCase(10, 0)]
    [TestCase(15, 0)]
    [TestCase(20, 0)]
    public void TestDivision_ByZero(int x, int y)
    {
        Assert.Throws<DivideByZeroException>(() => CustomMath.Divide(x, y));
    }

    [TestCase(10, 5)]
    [TestCase(15, 5)]
    [TestCase(20, 5)]
    public void TestIsDivisible_ValidValues(int x, int y)
    {
        ClassicAssert.IsTrue(CustomMath.IsDivisible(x, y));
    }

    [TestCase(1, 43)]
    [TestCase(2, 43)]
    [TestCase(3, 43)]
    public void TestIsDivisible_InvalidValues(int x, int y)
    {
        ClassicAssert.IsFalse(CustomMath.IsDivisible(x, y));
    }
    
}