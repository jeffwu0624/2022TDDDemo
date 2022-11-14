namespace TDDDemo;

public class CsvParser
{
    public IEnumerable<string> Parse(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return new List<string>().ToArray();

        var startIdx = value.IndexOf("\"", StringComparison.CurrentCultureIgnoreCase);
        var endInx = value.IndexOf("\"", startIdx + 1, StringComparison.CurrentCultureIgnoreCase);

        return new[] { value.Substring(startIdx + 1, endInx - 1) };
    }
}