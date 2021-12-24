List<Student> students = new List<Student>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] inputTokens = Console.ReadLine().Split();
    double[] grades = inputTokens.Skip(1).Select(double.Parse).ToArray();
    Student student = new Student(inputTokens[0], grades);

    students.Add(student);
}
var filteredStudents = students.Where(s => s.AvGrade >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.AvGrade);
foreach (var student in filteredStudents)
{
    Console.WriteLine($"{student.Name} -> {student.AvGrade:F2}");
}
public class Student
{
    public string Name { get; set; }
    public double[] Grades { get; set; }

    public Student(string name, double[] grades)
    {
        this.Name = name;
        this.Grades = grades;
        this.AvGrade = grades.Average();
    }
    public double AvGrade { get; }

}

