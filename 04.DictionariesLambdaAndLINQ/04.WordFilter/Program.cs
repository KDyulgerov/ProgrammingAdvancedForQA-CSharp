string[] input = Console.ReadLine()
    .Split()
    .Where(w => w.Length % 2 == 0)
    .ToArray();

Console.WriteLine(string.Join("\n", input));