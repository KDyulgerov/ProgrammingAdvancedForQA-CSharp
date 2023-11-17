var companyCollection = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputArray = input.Split(" -> ").ToArray();
    string companyName = inputArray[0];
    string companyId = inputArray[1];

    if(!companyCollection.ContainsKey(companyName))
    {
        companyCollection.Add(companyName, new List<string>());
    }
    if (!companyCollection[companyName].Contains(companyId))
    {
        companyCollection[companyName].Add(companyId);
    }

    input = Console.ReadLine();
}

foreach (var company in companyCollection)
{
    Console.WriteLine($"{company.Key}");
    foreach (var element in company.Value)
    {
        Console.WriteLine($"-- {element}");
    }
}