namespace ShoppingCart;
public class Cart
{
    private List<double> _items;

    public string Name;
    public Cart(string name)
    {
        Name = name;
        this._items = new List<double>();
    }

    public void AddItem(double item)
    {
        this._items.Add(item);
    }

    internal double GetAverage()
    {
        var result = 0.0;
        foreach (var item in this._items)
        {
            result += item;
        }

        result /= this._items.Count;

        return result;
    }

    public Statistics GetStatistics()
    {
        var result = new Statistics();
        result.Average = this.GetAverage();
        result.Max = this._items.Max();
        result.Min = this._items.Min();

        return result;
    }

    public override string ToString()
    {
        return $"{Name} has {this._items.Count} items";
    }
}