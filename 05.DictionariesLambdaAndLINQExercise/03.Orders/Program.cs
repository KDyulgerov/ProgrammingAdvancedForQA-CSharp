
string input = Console.ReadLine();

var collection = new Dictionary<string, List<decimal>>();

while (input != "buy")
{
    var inputArray = input.Split().ToArray();
    var product = inputArray[0];
    var price = decimal.Parse(inputArray[1]);
    var quantity = decimal.Parse(inputArray[2]);

    if (!collection.ContainsKey(product))
    {
        collection.Add(product, new() { price, quantity });
    }
    else
    {
        collection[product][0] = price;
        collection[product][1] += quantity;
    }

    input = Console.ReadLine();
}

foreach (var pair in collection)
{
    var totalPrice = pair.Value[0] * pair.Value[1];

    Console.WriteLine($"{pair.Key} -> {totalPrice:F2}");
}