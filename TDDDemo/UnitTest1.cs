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

    private void ParseResultShouldBe(IEnumerable<string> expected, string data)
    {
        CollectionAssert.AreEqual(expected, _parser.Parse(data));
    }
}