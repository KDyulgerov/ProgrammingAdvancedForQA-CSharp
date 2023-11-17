string input = Console.ReadLine();


var resourceCollection = new Dictionary<string, int>();

while (input != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (resourceCollection.ContainsKey(input)) 
    {
        resourceCollection[input] += quantity;
    }
    else
    {
        resourceCollection.Add(input, quantity);
    }

    input = Console.ReadLine();
}

foreach (var kvp in resourceCollection)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}