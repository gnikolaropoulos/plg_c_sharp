namespace ShoppingCart;

public class Statistics
{
    public double Average;
    public double Max;
    public double Min;

    public Statistics()
    {
        this.Average = 0.0;
        this.Max = double.MinValue;
        this.Min = double.MaxValue;
    }
}