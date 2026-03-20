namespace Lab1;

public class Item(int id, int value, int weight)
{
    public int Id { get; } = id;
    public int Value { get; } = value;
    public int Weight { get; } = weight;
    public double Ratio => (double)Value / Weight;

    public override string ToString()
    {
        return $"Id: {Id}, Value: {Value}, Weight: {Weight}, Ratio: {Ratio:F2}";
    }
}