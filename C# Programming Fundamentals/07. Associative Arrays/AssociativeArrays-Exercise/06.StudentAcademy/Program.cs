internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfStudents = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        for (int i = 0; i < numberOfStudents; i++)
        {
            string studentName = Console.ReadLine();
            double studentGrade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(studentName))
            {
                students.Add(studentName, new List<double> { studentGrade });
            }
            else
            {
                students[studentName].Add(studentGrade);
            }
        }

        students = students
            .Where(x => x.Value.Average() >= 4.50)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
        }
    }
}