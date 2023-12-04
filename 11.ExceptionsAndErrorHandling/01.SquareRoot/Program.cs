double SquareRoot(int number)
{
    return Math.Sqrt(number);
}

int input = int.Parse(Console.ReadLine());

try
{
    if (input < 0)
    {
        throw new ArgumentException();
    }
    
    Console.WriteLine(SquareRoot(input));
}
catch(ArgumentException)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}