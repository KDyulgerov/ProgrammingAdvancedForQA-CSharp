int repeat = int.Parse(Console.ReadLine());

var collection = new Dictionary<string, string>();

for (int i = 1; i <= repeat; i += 1) 
{
    string[] request = Console.ReadLine().Split().ToArray();
    var command = request[0];
    var username = request[1];

    if (command == "register")
    {
        var plateNumber = request[2];

        if (collection.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
        }
        else
        {
            collection.Add(username, plateNumber);

            Console.WriteLine($"{username} registered {plateNumber} successfully");
        }


    }
    else if (command == "unregister")
    {
        if (!collection.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            collection.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}
foreach (var kvp in collection)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}