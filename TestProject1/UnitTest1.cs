namespace TestProject1;

[TestClass]
public class UnitTest1
{
    private readonly Func<string, (int R, int G, int B)> getRainbowColor = color =>
    {
        return color.ToLower() switch
        {
            "червоний" => (255, 0, 0),
            "оранжевий" => (255, 165, 0),
            "жовтий" => (255, 255, 0),
            "зелений" => (0, 255, 0),
            "блакитний" => (0, 127, 255),
            "синій" => (0, 0, 255),
            "фіолетовий" => (139, 0, 255),
            _ => (-1, -1, -1) // Значення для невідомого кольору
        };
    };

    [TestMethod]
    [DataRow("червоний", 255, 0, 0)]
    [DataRow("оранжевий", 255, 165, 0)]
    [DataRow("жовтий", 255, 255, 0)]
    [DataRow("зелений", 0, 255, 0)]
    [DataRow("блакитний", 0, 127, 255)]
    [DataRow("синій", 0, 0, 255)]
    [DataRow("фіолетовий", 139, 0, 255)]
    [DataRow("невідомий", -1, -1, -1)]
    public void TestGetRainbowColor(string color, int expectedR, int expectedG, int expectedB)
    {
        var (R, G, B) = getRainbowColor(color);
        Assert.AreEqual(expectedR, R);
        Assert.AreEqual(expectedG, G);
        Assert.AreEqual(expectedB, B);
    }
}