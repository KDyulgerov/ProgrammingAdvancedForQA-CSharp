using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

Regex regex = new Regex(pattern);

MatchCollection validNames = regex.Matches(text);

foreach (Match name in validNames)
{
    Console.Write($"{name.Value} ");
}