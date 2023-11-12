﻿using System.Text;

string input = Console.ReadLine();

StringBuilder digits = new();
StringBuilder letters = new();
StringBuilder symbols = new();

foreach(char ch in input)
{
    if (char.IsDigit(ch))
    {
        digits.Append(ch);
    }
    else if (char.IsLetter(ch))
    {
        letters.Append(ch);
    }
    else
    {
        symbols.Append(ch);
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(symbols);