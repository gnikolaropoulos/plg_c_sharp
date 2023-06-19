namespace ShoppingCart;
public class Cart
{
    private string _name;
    private List<double> _items;

    public Cart(string name)
    {
        this._name = name;
        this._items = new List<double>();
    }

    public void AddItem(double item)
    {
        this._items.Add(item);
    }

    public double GetAverage()
    {
        var result = 0.0;
        foreach (var item in this._items)
        {
            result += item;
        }

        result /= this._items.Count;

        return result;
    }

    public override string ToString()
    {
        return $"{this._name} has {this._items.Count} items";
    }
}