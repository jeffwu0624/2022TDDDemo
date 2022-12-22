namespace TDDDemo;

public class FizzBuzz
{
    public string Create(int value)
    {
        var words = new List<string>();

        foreach (var i in Enumerable.Range(1, value)) words.Add(i.ToString());


        return string.Join(",", words);
    }
}