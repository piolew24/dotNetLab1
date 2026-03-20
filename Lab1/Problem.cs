namespace Lab1;

public class Problem(int numberOfItems, int seed)
{
    public List<Item> GenerateItems()
    {
        List<Item> generatedItems = new();
        Random random = new(seed);

        for (var i = 0; i < numberOfItems; i++)
        {
            var value = random.Next(1, 10);
            var weight = random.Next(1, 10);
            generatedItems.Add(new Item(i + 1, value, weight));
        }

        return generatedItems;
    }

    private static List<Item> SortItems(List<Item> items)
    {
        List<Item> sorted = new(items);
        sorted.Sort((a, b) => b.Ratio.CompareTo(a.Ratio));
        return sorted;
    }

    public List<Item> Solve(List<Item> items, int capacity)
    {
        List<Item> result = new();
        var sortedItems = SortItems(items);

        foreach (var item in sortedItems)
            if (item.Weight <= capacity)
            {
                capacity -= item.Weight;
                result.Add(item);
            }

        return result;
    }
}