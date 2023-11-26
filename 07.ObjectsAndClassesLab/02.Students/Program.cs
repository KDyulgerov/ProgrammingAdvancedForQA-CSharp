string input = Console.ReadLine();

List<Student> students = new List<Student>();

while (input != "end")
{
    string[] inputParts = input.Split().ToArray();
    string firstName = inputParts[0];
    string lastName = inputParts[1];
    int age = int.Parse(inputParts[2]);
    string homeTown = inputParts[3];

    Student student = new Student(firstName, lastName, age, homeTown);
    students.Add(student);

    input = Console.ReadLine();
}

string cityName = Console.ReadLine();

foreach (Student student in students.Where(s => s.HomeTown == cityName))
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}


