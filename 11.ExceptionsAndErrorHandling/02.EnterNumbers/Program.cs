using System.Globalization;

static int ReadNumber(int start, int end)
{
    int input = int.Parse(Console.ReadLine());

    if (input <= start || input >= end)
    {
        throw new ArgumentException();
    }

    return input;
}

var numbers = new List<int>();

int maxNum = 1;

while (numbers.Count < 10)
{
    try
    {
        int num = ReadNumber(maxNum, 100);

        numbers.Add(num);
        maxNum = num;
    }
    catch (ArgumentException)
    {
        Console.WriteLine($"Your number is not in range {maxNum} - 100!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }

}

Console.WriteLine(string.Join(", ", numbers));