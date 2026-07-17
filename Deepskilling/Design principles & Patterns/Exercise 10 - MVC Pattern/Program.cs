Student student = new Student("Ruthvik", 101, "A");

StudentView view = new StudentView();

StudentController controller = new StudentController(student, view);

Console.WriteLine("Initial Details:");
controller.UpdateView();

Console.WriteLine();

controller.SetStudentName("Siva Sai Ruthvik");
controller.SetStudentGrade("A+");

Console.WriteLine("Updated Details:");
controller.UpdateView();