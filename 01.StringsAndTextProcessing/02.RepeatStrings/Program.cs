string[] arrayInput = Console.ReadLine().Split();

string repeatedWords = string.Empty;

foreach(string word in arrayInput)
{
    int repeateCount = word.Length;

    for(int i = 1; i <= repeateCount; i++)
    {
        repeatedWords += word;
    }
}

Console.WriteLine(repeatedWords);
