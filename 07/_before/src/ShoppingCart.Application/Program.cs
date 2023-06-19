namespace ShoppingCart;

class ShoppingCart
{
    public static void Main(string[] args)
    {
        var cart = new Cart("George's Cart");
        cart.AddItem(new Item { Price = 12.7, Name = "Milk" });
        cart.AddItem(new Item { Price = 10.3, Name = "Bread" });
        cart.AddItem(new Item { Price = 6.11, Name = "Butter" });
        cart.AddItem(new Item { Price = 4.1, Name = "Cheese" });
        cart.AddItem(new Item { Price = 56.1, Name = "Steak" });


        var stats = cart.GetStatistics();

        Console.WriteLine($"The average grade is {stats.Average:N1}");

    }
}