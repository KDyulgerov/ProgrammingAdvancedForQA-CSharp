using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"\+359([\s-])2\1\d{3}\1\d{4}\b";

Regex regex = new Regex(pattern);

MatchCollection validNumber = regex.Matches(text);

Console.WriteLine(string.Join(", ", validNumber));