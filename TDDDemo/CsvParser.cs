namespace TDDDemo;

public class CsvParser
{
    public IEnumerable<string> Parse(string value)
    {
        var result = new List<string>();

        if (string.IsNullOrWhiteSpace(value)) return result;

        foreach (var data in value.Split(","))
        {
            var startIdx = data.IndexOf("\"", StringComparison.CurrentCultureIgnoreCase);
            var endInx = data.IndexOf("\"", startIdx + 1, StringComparison.CurrentCultureIgnoreCase);

            result.Add(data.Substring(startIdx + 1, endInx - 1));
        }

        return result;
    }
}