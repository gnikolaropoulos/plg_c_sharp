namespace ShoppingCart.tests;

public class TypeTests
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
        cart.AddItem(new Item { Price = 5.0, Name = "Item 1" });
        cart.AddItem(new Item { Price = 20.0, Name = "Item 2" });
        cart.AddItem(new Item { Price = 35.0, Name = "Item 3" });
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

    [Fact]
    public void CreateCartReturnsDifferentCarts()
    {
        var cart1 = new Cart("My Cart");
        var cart2 = new Cart("My Second Cart");

        Assert.Equal("My Cart", cart1.Name);
        Assert.Equal("My Second Cart", cart2.Name);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        var cart1 = new Cart("My Cart");
        var cart2 = cart1;

        Assert.Same(cart1, cart2);
        Assert.True(Object.ReferenceEquals(cart1, cart2));
    }

    [Fact]
    public void CanSetNameFromReference()
    {
        var cart1 = CreateCart("My Cart");
        SetName(cart1, "My New Cart");

        Assert.Equal("My New Cart", cart1.Name);
    }

    [Fact]
    public void CannotChangeNameFromReference()
    {
        var cart1 = CreateCart("My Cart");
        SetNameToNewCart(cart1, "My New Cart");

        Assert.Equal("My Cart", cart1.Name);
    }

    [Fact]
    public void CanChangeNameWhenPassByRef()
    {
        var cart1 = CreateCart("My Cart");
        SetNameToNewCartByRef(ref cart1, "My New Cart");

        Assert.Equal("My New Cart", cart1.Name);
    }


    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        string name = "George";
        var upper = MakeUpperCase(name);

        Assert.Equal("George", name);
    }

    private object MakeUpperCase(string astring)
    {
        return astring.ToUpper();
    }

    private void SetNameToNewCartByRef(ref Cart cart, string name)
    {
        cart = new Cart(name);
    }

    private void SetNameToNewCart(Cart cart, string name)
    {
        cart = new Cart(name);
    }

    private void SetName(Cart cart, string name)
    {
        cart.Name = name;
    }

    public Cart CreateCart(string name)
    {
        return new Cart(name);
    }
}

