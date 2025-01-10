namespace TestProject1;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void TestMethod1()
    {
        int[] numbers = { -5, 10, 0, 23, -8, 7, 19, -15, 3 };
        Func<int[], int> countPositiveNumbers = arr => arr.Count(num => num > 0);
        
        int count = countPositiveNumbers(numbers);
        
        Assert.AreEqual(4, count, "The count of positive numbers is incorrect.");
    }
}