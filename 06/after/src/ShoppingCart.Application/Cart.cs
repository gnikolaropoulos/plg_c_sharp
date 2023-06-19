namespace ShoppingCart;
public class Cart
{
    private List<Item> _items;

    public string Name;
    public Cart(string name)
    {
        Name = name;
        this._items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        if (item.Price <= 0 || item.Price > 10000)
        {
            throw new ArgumentOutOfRangeException(nameof(item.Price));
        }

        this._items.Add(item);
    }

    internal double GetAverage()
    {
        var result = 0.0;
        foreach (var item in this._items)
        {
            result += item.Price;
        }

        result /= this._items.Count;

        return result;
    }

    public Statistics GetStatistics()
    {
        var result = new Statistics();
        result.Average = 0.0;
        // result.Max = _items.Max(i => i.Price);
        // result.Min = _items.Min(i => i.Price);
        foreach (var item in _items)
        {
            result.Average += item.Price;
            result.Max = Math.Max(item.Price, result.Max);
            result.Min = Math.Min(item.Price, result.Min);
        }

        result.Average /= _items.Count;

        return result;
    }

    public override string ToString()
    {
        return $"{Name} has {this._items.Count} items";
    }
}