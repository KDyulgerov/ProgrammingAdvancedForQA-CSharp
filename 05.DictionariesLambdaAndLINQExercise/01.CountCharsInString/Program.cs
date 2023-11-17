
string input = Console.ReadLine();

var charCollection = new Dictionary<char, int>();

foreach(char ch in input)
{
    if(ch == ' ')
    {
        continue;
    }
    if (charCollection.ContainsKey(ch))
    {
        charCollection[ch]++;
    }
    else
    {
        charCollection.Add(ch, 1);
    }
}

foreach (var pair in charCollection)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}

