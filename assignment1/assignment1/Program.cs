using Assignment_1;

class Program
{
    static void Main()
    {
        var student1 = StudentMethods.CreateStudent(1, StudentType.FullTime, "Mansi", "Sharma");
        var student2 = StudentMethods.CreateStudent(2, StudentType.FullTime, "Milan", "Parihar");
        var student3 = StudentMethods.CreateStudent(3, StudentType.PartTime, "Babbar", "Sharma");

        Console.WriteLine("Assignment One");

        StudentMethods.OutputStudent(student1);
        StudentMethods.OutputStudent(student2);
        StudentMethods.OutputStudent(student3);
    }
}