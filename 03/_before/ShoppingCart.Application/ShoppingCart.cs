
public class ShoppingCart
{
    public List<Item> Items;

    public ShoppingCart()
    {
        Items = new List<Item>();
    }

    public override string ToString()
    {
        var result = "";
        foreach (var item in Items)
        {
            result += $"Description is: {item.Description} and price is: {item.Price}\n";
        }

        return result;
    }
}