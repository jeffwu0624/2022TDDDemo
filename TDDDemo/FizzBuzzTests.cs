namespace TDDDemo;

[TestFixture]
public class FizzBuzzTests
{
    [SetUp]
    public void SetUp()
    {
        _fizzBuzz = new FizzBuzz();
    }

    private FizzBuzz _fizzBuzz;

    [Test]
    public void input_one()
    {
        FizzBuzzShouldBe(1, "1");
    }

    [Test]
    public void input_two()
    {
        FizzBuzzShouldBe(2, "1,2");
    }

    [Test]
    public void input_three()
    {
        FizzBuzzShouldBe(3, "1,2,fizz");
    }

    [Test]
    public void input_five()
    {
        FizzBuzzShouldBe(5, "1,2,fizz,4,buzz");
    }


    private void FizzBuzzShouldBe(int value, string expected)
    {
        var result = _fizzBuzz.Create(value);

        Assert.AreEqual(expected, result);
    }
}