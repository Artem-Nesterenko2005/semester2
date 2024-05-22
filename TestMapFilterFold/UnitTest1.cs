
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestMap()
    {
        var testMap = new ListFunction();
        Assert.That(testMap.Map(new List<int> { 1, 2, 3, 4 }, x => x * 3), Is.EqualTo(new List<int> { 3, 6, 9, 12 }));
    }

    [Test]
    public void TestFilter()
    {
        var testMap = new ListFunction();
        Assert.That(testMap.Filter(new List<int> { 3, 6, 7, 102 }, x => x % 2 == 0), Is.EqualTo(new List<int> { 6, 102 }));
    }

    [Test]
    public void TestFold()
    {
        var testMap = new ListFunction();
        Assert.That(testMap.Fold(new List<int> { 5, 3, 8 }, 2, (x, y) => x + y), Is.EqualTo(18));
    }
}

