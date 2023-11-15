List<string> elemets = Console.ReadLine() // java c# php ... 
    .Split()
    .Select(x => x.ToLower())
    .ToList();

Dictionary<string, int> collection = new();

foreach(var element in elemets)
{
    if (collection.ContainsKey(element))
    {
        collection[element] += 1;
    }
    else
    {
        collection.Add(element, 1);
    }
}
foreach(var pair in collection)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}