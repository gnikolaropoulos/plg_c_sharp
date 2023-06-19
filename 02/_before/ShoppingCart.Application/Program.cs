namespace ShoppingCart;

class ShoppingCart
{
    public static void Main(string[] args)
    {
        int x = 1;
        string myString = "lion";
        if (args.Length > 0)
        {
            Console.WriteLine($"Hello, {x}!");
            Console.WriteLine("Hello, " + x + "!");
            Console.WriteLine("Hello, " + myString + "!");
            Console.WriteLine($"Hello, {myString} and {x}!");
        }
        else
        {
            Console.WriteLine("Hello World!");
        }
    }
}

