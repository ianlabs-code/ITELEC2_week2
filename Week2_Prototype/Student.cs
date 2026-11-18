class Student
{
    public string Name { get; }
    public int Age { get; }
    public double GPA { get; private set; }

    public Student(string name, int age, double gpa)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required.");

        if (age <= 0)
            throw new ArgumentException("Age must be greater than 0.");

        if (gpa < 0.0 || gpa > 4.0)
            throw new ArgumentException("GPA must be between 0.0 and 4.0.");

        Name = name;
        Age = age;
        GPA = gpa;
    }

    public bool UpdateGPA(double newGPA)
    {
        if (newGPA < 0.0 || newGPA > 4.0)
            return false;

        GPA = newGPA;
        return true;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"GPA: {GPA}");
    }
}