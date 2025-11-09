public class Course
{
    public string _courseName;
    public List<Student> _students = new List<Student>();

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course Name: {_courseName}");
        Console.WriteLine("Students in course:");
        foreach (Student s in _students)
        {
            Console.Write("\t");
            s.DisplayName();
        }
    }

}