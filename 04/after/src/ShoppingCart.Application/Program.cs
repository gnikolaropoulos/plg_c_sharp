namespace ShoppingCart;

class ShoppingCart
{
    public static void Main(string[] args)
    {
        var cart = new Cart("George's Cart");
        cart.AddItem(12.7);
        cart.AddItem(10.3);
        cart.AddItem(6.11);
        cart.AddItem(4.1);
        cart.AddItem(56.1);


        var prices = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
        prices.Add(56.1);

        var result = 0.0;
        foreach (var price in prices)
        {
            result += price;
        }

        result /= prices.Count;
        var resultFromMyClass = cart.GetAverage();

        Console.WriteLine($"The average grade is {result:N1}");
        Console.WriteLine($"The average grade is {resultFromMyClass:N1}");
    }
}