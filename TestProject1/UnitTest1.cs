namespace TestProject1;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void TestMethod1()
    {
        int[] numbers = { -5, 10, 0, -8, -5, 7, -15, 3, -8 };
        Func<int[], int[]> getUniqueNegativeNumbers = arr => arr.Where(num => num < 0).Distinct().ToArray();
        
        int[] uniqueNegativeNumbers = getUniqueNegativeNumbers(numbers);
        
        CollectionAssert.AreEqual(new int[] { -5, -8, -15 }, uniqueNegativeNumbers, "The unique negative numbers are incorrect.");
    }
}