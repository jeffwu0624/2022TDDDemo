namespace TDDDemo;

public class FizzBuzz
{
    public string Create(int value)
    {
        var words = new List<string>();

        var divWords = new List<DivWord>
        {
            new(15, "fizzbuzz"),
            new(3, "fizz"),
            new(5, "buzz")
        };


        foreach (var i in Enumerable.Range(1, value))
        {
            var word = divWords.FirstOrDefault(div => i % div.Value == 0);

            if (word != null)
            {
                words.Add(word.Word);
            }
            else
            {
                words.Add(i.ToString());
            }
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