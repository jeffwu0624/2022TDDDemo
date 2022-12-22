namespace TDDDemo;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void input_one()
    {
        var fizzBuzz = new FizzBuzz();

        var result = fizzBuzz.Create(1);

        Assert.AreEqual("1", result);
    }
}