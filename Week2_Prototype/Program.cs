var student1 = new Student("Luke Nathaniel", 20, 3.50);
var student2 = new Student("Rafael Lotino", 21, 3.00);

Console.WriteLine("=== STUDENT 1 ===");
student1.DisplayInfo();

Console.WriteLine();

Console.WriteLine("=== STUDENT 2 ===");
student2.DisplayInfo();

Console.WriteLine();

Console.WriteLine("=== TESTING GPA RULE ===");

bool validUpdate = student1.UpdateGPA(3.75);
Console.WriteLine($"Valid GPA update: {validUpdate}");
Console.WriteLine($"New GPA: {student1.GPA}");

bool invalidUpdate = student1.UpdateGPA(5.00);
Console.WriteLine($"Invalid GPA update: {invalidUpdate}");
Console.WriteLine($"GPA after invalid update: {student1.GPA}");

try
{
    var invalidStudent = new Student("Invalid Student", 20, 5.0);
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine("Rejected invalid student:");
    Console.WriteLine(ex.Message);
}