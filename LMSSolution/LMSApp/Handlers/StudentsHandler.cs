
namespace LMSApp.Handlers;
using LMSApp.Managers;
using LMSApp.Entities;

public class StudentsHandler
{
    private StudentManager studentManager;

    public StudentsHandler(StudentManager studentManager)
    {
        this.studentManager = studentManager;
    }

    public void AddStudent(string name)
    {
        studentManager.AddStudent(name);
    }

    public void RemoveStudent(int id)
    {
        Student student = studentManager.GetStudentById(id);
        studentManager.RemoveStudent(student);
    }

    public List<Student> GetAllStudents()
    {
        return studentManager.GetAllStudents();
    }

    public Student GetStudentById(int id)
    {
        return studentManager.GetStudentById(id);
    }

    public void  HandleStudentMenuOperations(int choice)
    {
        switch (choice)
        {
            //Add Student
            case 1:
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                AddStudent(name);
                Console.WriteLine("Student added successfully.");
                break;

            //Remove Student
            case 2:
                Console.Write("Enter student ID to remove: ");
                int idToRemove = int.Parse(Console.ReadLine());
                RemoveStudent(idToRemove);
                Console.WriteLine("Student removed successfully.");
                break;

            //Display Students
            case 3:
                {
                     List<Student> students = GetAllStudents();
                Console.WriteLine("Students:");
                foreach (Student s in students)
                {
                    Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
                } 
                }
               break;

            //Display Student Details
            case 4:
                {
                    Console.Write("Enter student ID to view details: ");
                    int idToView = int.Parse(Console.ReadLine());
                    Student student = GetStudentById(idToView);
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
                }
                break;
            }
    }
}