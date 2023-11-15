int repeat = int.Parse(Console.ReadLine());


Dictionary<string, List<string>> synonymsCollection = new();

for (int i = 1; i <= repeat; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (synonymsCollection.ContainsKey(word))
    {
        synonymsCollection[word].Add(synonym);
    }
    else
    {
        synonymsCollection.Add(word, new List<string> { synonym });
    }
}
foreach(var pair in synonymsCollection)
{
    Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
}
