List<int> numbers = Console.ReadLine() // 2, 3, 5, 6
    .Split()
    .Select(int.Parse)
    .ToList();

SortedDictionary<int, int> collection = new();

foreach (var number in numbers)
{
    if (collection.ContainsKey(number))
    {
        collection[number] += 1;
    }
    else
    {
        collection.Add(number, 1);
    }
}

foreach (var pair in collection)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}