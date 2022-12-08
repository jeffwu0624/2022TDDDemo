namespace TDDDemo;

public class CsvParser
{
    public IEnumerable<string> Parse(string value)
    {
        var result = new List<string>();

        if (!string.IsNullOrWhiteSpace(value))
        {
            while (!string.IsNullOrEmpty(value))
            {
                var startIdx = value.IndexOf("\"", StringComparison.CurrentCultureIgnoreCase);
                var endInx = value.IndexOf("\"", startIdx + 1, StringComparison.CurrentCultureIgnoreCase);
                result.Add(value.Substring(startIdx + 1, endInx - 1));

                if (value.Length < endInx + 2) break;

                value = value.Substring(endInx + 2);
            }
        }

        return result;
    }
}