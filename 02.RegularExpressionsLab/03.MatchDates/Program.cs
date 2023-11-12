using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"(?<day>\d{2})(?<sep>[\.\/\-])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})\b";

Regex regex = new Regex(pattern);

MatchCollection dates = regex.Matches(text);

foreach(Match date in dates)
{
    Console.WriteLine($"Day: {date.Groups["day"].Value}," +
                     $" Month: {date.Groups["month"].Value}," +
                     $" Year: {date.Groups["year"].Value}");
}

