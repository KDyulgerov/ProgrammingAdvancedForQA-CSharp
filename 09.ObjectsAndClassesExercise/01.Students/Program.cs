int countStudents = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int i = 1; i <= countStudents; i++)
{
    string studentData = Console.ReadLine();
    string firstName = studentData.Split()[0];
    string lastName = studentData.Split()[1];
    double grade = double.Parse(studentData.Split()[2]);

    var student = new Student(firstName, lastName, grade);
    students.Add(student);
}

students = students.OrderByDescending(s => s.Grade).ToList();

foreach(var student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}
