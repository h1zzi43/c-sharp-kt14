namespace App.Topics.Dictionary.T3_Dictionary;

public static class DictionaryTasks
{
    public static List<KeyValuePair<string, int>> TopNWords(string text, int n)
    {
        if (string.IsNullOrEmpty(text) || n <= 0)
        {
            return new List<KeyValuePair<string, int>>();
        }

        var wordFrequencies = new Dictionary<string, int>();
        string currentWord = "";

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                currentWord += c;
            }
            else if (currentWord.Length > 0)
            {
                string normalizedWord = currentWord.ToLower();
                if (wordFrequencies.ContainsKey(normalizedWord))
                {
                    wordFrequencies[normalizedWord]++;
                }
                else
                {
                    wordFrequencies[normalizedWord] = 1;
                }
                currentWord = "";
            }
        }

        if (currentWord.Length > 0)
        {
            string normalizedWord = currentWord.ToLower();
            if (wordFrequencies.ContainsKey(normalizedWord))
            {
                wordFrequencies[normalizedWord]++;
            }
            else
            {
                wordFrequencies[normalizedWord] = 1;
            }
        }

        return wordFrequencies
            .OrderByDescending(kv => kv.Value)
            .ThenBy(kv => kv.Key)
            .Take(n)
            .ToList();
    }
}
