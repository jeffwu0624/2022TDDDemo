namespace TDDDemo;

public class FizzBuzz
{
    public string Create(int value)
    {
        var words = new List<string>();

        foreach (var i in Enumerable.Range(1, value))
        {
            var divNumberLookup = new Dictionary<int, string>
            {
                { 15, "fizzbuzz" },
                { 3, "fizz" },
                { 5, "buzz" }
            };

            var divWord = divNumberLookup.FirstOrDefault(pair => i % pair.Key == 0).Value;

            if (!string.IsNullOrEmpty(divWord))
            {
                words.Add(divWord);
            }
            else
            {
                words.Add(i.ToString());
            }
        }


        return string.Join(",", words);
    }
}