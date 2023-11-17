int repeat = int.Parse(Console.ReadLine());

var studentsCollection = new Dictionary<string, List<double>>();

for (int i = 1; i <= repeat; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (studentsCollection.ContainsKey(student))
    {
        studentsCollection[student].Add(grade);
    }
    else
    {
        studentsCollection.Add(student, new() { grade });
    }
}

var excelent = studentsCollection.Where(x => x.Value.Average() >= 4.50);

foreach (var student in excelent)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
}
