string[] bannedWords = Console.ReadLine().Split(", ");
string? text = Console.ReadLine();

foreach (string banWord in bannedWords)
{
    if (text.Contains(banWord))
    {
        text = text.Replace(banWord, new string ('*', banWord.Length));
    }
}

Console.WriteLine(text);