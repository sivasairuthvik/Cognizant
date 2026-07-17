public class StudentView
{
    public void DisplayStudentDetails(Student student)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("----------------");
        Console.WriteLine($"Name  : {student.Name}");
        Console.WriteLine($"ID    : {student.Id}");
        Console.WriteLine($"Grade : {student.Grade}");
    }
}