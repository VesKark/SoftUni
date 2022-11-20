internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputStudent = input.Split(" : ");
            string courseName = inputStudent[0];
            string studentName = inputStudent[1];

            if (!courses.ContainsKey(courseName))
            {
                courses.Add(courseName, new List<string> { studentName });
            }
            else
            {
                courses[courseName].Add(studentName);
            }
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count()}");

            foreach (string student in course.Value)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}