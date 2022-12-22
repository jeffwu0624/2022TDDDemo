namespace TDDDemo;

public class FizzBuzz
{
    private readonly List<DivWord> _divWords = new()
    {
        new(15, "fizzbuzz"),
        new(3, "fizz"),
        new(5, "buzz")
    };

    public string Create(int value)
    {
        var words = new List<string>();

        foreach (var i in Enumerable.Range(1, value))
        {
            var word = _divWords.FirstOrDefault(div => i % div.Value == 0);

            words.Add(word != null ? word.Word : i.ToString());
        }


        return string.Join(",", words);
    }
}

public class DivWord
{
    public DivWord(int value, string word)
    {
        Value = value;
        Word = word;
    }

    public int Value { get; }
    public string Word { get; }
}