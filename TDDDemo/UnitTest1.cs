namespace TDDDemo;

public class CvsParserTests
{
    private CsvParser _parser;

    [SetUp]
    public void SetUp()
    {
        _parser = new CsvParser();
    }

    [Test]
    public void parse_empty_string()
    {
        var values = _parser.Parse("");
        Assert.That(values, Is.Empty);
    }

    [Test]
    public void parse_one_word()
    {
        var data = "\"ABC\"";
        ParseResultShouldBe(new[] { "ABC" }, data);
    }

    [Test]
    public void parse_two_word()
    {
        var data = "\"ABC\",\"DEF\"";
        var expected = new[]
        {
            "ABC",
            "DEF"
        };
        ParseResultShouldBe(expected, data);
    }

    [Test]
    public void parse_with_common()
    {
        var data = "\"ABC\",\"DEF,GHI\"";
        var expected = new[]
        {
            "ABC",
            "DEF,GHI"
        };
        ParseResultShouldBe(expected, data);
    }


    private void ParseResultShouldBe(IEnumerable<string> expected, string data)
    {
        CollectionAssert.AreEqual(expected, _parser.Parse(data));
    }
}