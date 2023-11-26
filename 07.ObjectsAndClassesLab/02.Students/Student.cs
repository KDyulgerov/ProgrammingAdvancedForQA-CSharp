
public class Student
{
    string firstName;
    string lastName;
    int age;
    string homeTown;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string HomeTown
    {
        get { return homeTown; }
        set { homeTown = value; }
    }

    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }
}
