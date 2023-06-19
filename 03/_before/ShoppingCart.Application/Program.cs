
using System;

public class MyCartApplication
{
    public static void Main(string[] args)
    {
        var cart = new ShoppingCart();
        // var shirt = new Item();
        // shirt.Description = "My shirt";
        // shirt.Price = 5.99;
        var shirt = new Shirt();
        shirt.Description = "My shirt";
        shirt.Price = 5.99;
        var shoes = new Item { Description = "Vaso's Shoes", Price = 20 };
        var trousers = new Item(15.99, "Blue trousers");
        cart.Items.Add(shirt);
        cart.Items.Add(shoes);
        cart.Items.Add(trousers);

        Console.WriteLine("My cart contains:");
        // foreach (var item in cart.Items)
        // {
        //     Console.WriteLine($"Description is: {item.Description} and price is: {item.Price}");
        // }
        Console.WriteLine(cart.ToString());

        Console.WriteLine(shirt.Print());
        shirt.PrintToConsole();



        var anItem = new Item(10, "my description");

        CanChange(anItem);
        Console.WriteLine(anItem.Price);
    }

    public static void CanChange(Item item)
    {
        item = new Item(40, "test");
        Console.WriteLine(item.Price);
    }
}





