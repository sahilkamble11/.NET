
namespace LMSApp.Handlers;
using LMSApp.Managers;
using LMSApp.Entities;

public class InstructorsHandler
{
    private InstructorManager instructorManager;

    public InstructorsHandler(InstructorManager instructorManager)
    {
        this.instructorManager = instructorManager;
    }

    public void AddInstructor(string name)
    {
        instructorManager.AddInstructor(name);
    }

    public void RemoveInstructor(int id)
    {
        Instructor instructor = instructorManager.GetInstructorById(id);
        instructorManager.RemoveInstructor(instructor);
    }

    public List<Instructor> GetAllInstructors()
    {
        return instructorManager.GetAllInstructors();
    }

    public Instructor GetInstructorById(int id)
    {
        return instructorManager.GetInstructorById(id);
    }

    public void  HandleInstructorMenuOperations(int choice)
    {
        switch (choice)
        {
            //Add Instructor
            case 1:
                Console.Write("Enter instructor name: ");
                string name = Console.ReadLine();
                AddInstructor(name);
                Console.WriteLine("Instructor added successfully.");
                break;

            //Remove Instructor
            case 2:
                Console.Write("Enter instructor ID to remove: ");
                int idToRemove = int.Parse(Console.ReadLine());
                RemoveInstructor(idToRemove);
                Console.WriteLine("Instructor removed successfully.");
                break;

            //Display Instructors
            case 3:
                {
                     List<Instructor> instructors = GetAllInstructors();
                Console.WriteLine("Instructors:");
                foreach (Instructor i in instructors)
                {
                    Console.WriteLine($"ID: {i.Id}, Name: {i.Name}");
                } 
                }
               break;

            //Display Instructor Details
            case 4:
                {
                    Console.Write("Enter instructor ID to view details: ");
                    int idToView = int.Parse(Console.ReadLine());
                    Instructor instructor = GetInstructorById(idToView);
                    Console.WriteLine($"ID: {instructor.Id}, Name: {instructor.Name}");
                }
                break;
            }
    }
}