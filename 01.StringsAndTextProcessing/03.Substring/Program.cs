string toRemove = Console.ReadLine();
string input = Console.ReadLine();

while (input.Contains(toRemove))
{
    int startIndexForRemove = input.IndexOf(toRemove);
    input = input.Remove(startIndexForRemove, toRemove.Length);
}

Console.WriteLine(input);