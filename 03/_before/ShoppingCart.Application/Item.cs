
public class Item
{
    public double Price;
    public string Description;

    public Item()
    {
        Price = 0.0;
        Description = "No description";
    }

    public Item(double price, string description)
    {
        Price = price;
        Description = description;
    }

    public virtual string Print()
    {
        return $"Description is: {Description} and price is: {Price}";
    }
}

public class Shirt : Item
{
    public string Size;

    public void PrintToConsole()
    {
        Console.WriteLine($"Shirt description is: {Description} and price is: {Price}");
    }
}
