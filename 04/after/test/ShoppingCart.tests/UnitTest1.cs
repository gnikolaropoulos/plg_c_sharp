namespace ShoppingCart.tests;

public class UnitTest1
{
    [Fact]
    public void MyFirstTest()
    {
        // arrange
        var x = 7;
        var y = 9;
        var expected = x * y;

        // act
        var actual = x * y;

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsCartCreated()
    {
        // arrange
        var cart = new Cart("My Cart");

        // act
        var actual = cart.ToString();

        // assert
        Assert.Equal("My Cart has 0 items", actual);
    }

    [Fact]
    public void CanCalculateStatistics()
    {
        // arrange
        var cart = new Cart("My Cart");
        cart.AddItem(5.0);
        cart.AddItem(20.0);
        cart.AddItem(35.0);
        var statistics = cart.GetStatistics();

        // act
        var high = 35.0;
        var low = 5.0;
        var average = 20.0;

        // assert
        Assert.Equal(high, statistics.Max);
        Assert.Equal(low, statistics.Min);
        Assert.Equal(average, statistics.Average);

    }
}