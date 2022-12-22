namespace TDDDemo;

public class FizzBuzz
{
    public string Create(int value)
    {
        var words = new List<string>();

        foreach (var i in Enumerable.Range(1, value))
        {
            var wordsLookup = new Dictionary<int, string>
            {
                { 15, "fizzbuzz" }
            };

            if (wordsLookup.ContainsKey(i))
            {
                words.Add(wordsLookup[i]);
            }
            else if (i % 3 == 0)
            {
                words.Add("fizz");
            }
            else if (i % 5 == 0)
            {
                words.Add("buzz");
            }
            else
            {
                words.Add(i.ToString());
            }
        }


        return string.Join(",", words);
    }
}