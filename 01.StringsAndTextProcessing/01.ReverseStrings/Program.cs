static string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();

    Array.Reverse(charArray);

    return new string(charArray);
}

string input = Console.ReadLine();

List<string> inputNewList = new();
List<string> inputOldList = new();

while (input != "end")
{
    inputOldList.Add(input);
    string result = ReverseString(input);
    inputNewList.Add(result);

    input = Console.ReadLine();
}

for (int i = 0; i < inputNewList.Count; i++)
{
    Console.WriteLine($"{inputOldList[i]} = {inputNewList[i]}");
}



