namespace TDDDemo;

public class CvsParserTests
{
    [Test]
    public void parse_empty_string()
    {
        var parser = new CsvParser();
        var values = parser.Parse("");
        Assert.That(values, Is.Empty);
    }
}