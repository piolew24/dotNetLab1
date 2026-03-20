using Lab1;

namespace TestProject1;

[TestClass]
public class ProblemTests
{
    [TestMethod]
    public void Solve_WhenAtLeastOneItemFits_ReturnsAtLeastOneItem()
    {
        var problem = new Problem(0, 0);
        var items = new List<Item>
        {
            new(1, 10, 4),
            new(2, 8, 5),
            new(3, 5, 2)
        };

        var result = problem.Solve(items, 3);

        Assert.IsTrue(result.Count >= 1);
    }

    [TestMethod]
    public void Solve_WhenNoItemFits_ReturnsEmptyList()
    {
        var problem = new Problem(0, 0);
        var items = new List<Item>
        {
            new(1, 10, 4),
            new(2, 8, 5)
        };

        var result = problem.Solve(items, 3);

        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void Solve_ForKnownInstance_ReturnsExpectedItemIds()
    {
        var problem = new Problem(0, 0);
        var items = new List<Item>
        {
            new(1, 10, 5),
            new(2, 9, 3),
            new(3, 4, 2),
            new(4, 7, 7)
        };

        var result = problem.Solve(items, 5);

        CollectionAssert.AreEqual(new[] { 2, 3 }, result.Select(x => x.Id).ToArray());
        Assert.IsTrue(result.Sum(x => x.Weight) <= 5);
    }

    [TestMethod]
    public void Item_ToString_FormatsCorrectly()
    {
        var item = new Item(1, 1, 3);

        var text = item.ToString();

        Assert.AreEqual("Id: 1, Value: 1, Weight: 3, Ratio: 0,33", text);
    }

    [TestMethod]
    public void GenerateItems_ReturnsRequestedCount_AndSequentialIds()
    {
        var problem = new Problem(5, 3);

        var items = problem.GenerateItems();

        Assert.AreEqual(5, items.Count);
        CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, items.Select(x => x.Id).ToArray());
    }
}