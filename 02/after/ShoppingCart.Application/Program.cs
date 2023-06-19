namespace ShoppingCart;
using System.Collections.Generic;
using System;

class ShoppingCart
{
    public static void Main(string[] args)
    {
        var numbers = new[] { 10, 20, 30, 40 };
        var prices = new List<double>() { 10.5, 20.5, 30.5, 40.5 };
        //prices.Add(21.4);

        var arrayResult = 0.0;
        for (var i = 0; i < numbers.Length; i++)
        {
            // it's the same as saying array_result = array_result + numbers[i];
            arrayResult += numbers[i];
        }

        Console.WriteLine(arrayResult);

        var listResult = 0.0;
        // for (var i = 0; i < prices.Count; i++)
        // {
        //     list_result += prices[i];
        // }
        foreach (var number in prices)
        {
            listResult += number;
        }

        Console.WriteLine(listResult);

        if (args.Length > 0)
        {
            Console.WriteLine($"Hello, {args[0]}!");
        }
        else
        {
            Console.WriteLine("Hello!");
        }
    }
}