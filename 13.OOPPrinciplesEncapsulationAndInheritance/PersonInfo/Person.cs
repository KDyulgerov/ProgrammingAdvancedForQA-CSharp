using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    private const int NAME_MIN_LENGHT = 3;
    public string FirstName
    {
        get { return this._firstName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGHT)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            this._firstName = value;
        }
    }

    public string LastName
    {
        get { return this._lastName; }
        set
        {
            if (value.Length < NAME_MIN_LENGHT)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            this._lastName = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this._age = value;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }

    public Person (string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
}
