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

    private void FizzBuzzShouldBe(int value, string expected)
    {
        var result = _fizzBuzz.Create(value);

        Assert.AreEqual(expected, result);
    }
}