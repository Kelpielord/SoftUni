using System;
using System.Collections;
using System.Globalization;

Dictionary<string, Student> studentsDict = new Dictionary<string, Student>();
while (true)
{
    string input = Console.ReadLine();
    if (input == "end of dates")
    {
        break;
    }
    string[] inputTokens = input.Split(' ', ',').ToArray();
    string studentName = inputTokens[0];
    List<DateTime> dates = inputTokens
        .Skip(1)
        .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
        .ToList();
    studentsDict.Add(studentName, new Student(studentName, dates));
}
while (true)
{
    string input = Console.ReadLine();
    if (input == "end of comments")
    {
        break;
    }
    string[] inputTokens = input.Split('-').ToArray();
    if (!studentsDict.ContainsKey(inputTokens[0]))
    {
        continue;
    }
    studentsDict[inputTokens[0]].Comments.Add(inputTokens[1]);

}

foreach (var student in studentsDict.Values.OrderBy(x => x.Name))
{
    Console.WriteLine($"{student.Name}");
    Console.WriteLine("Comments: ");
    foreach (var comment in student.Comments)
    {
        Console.WriteLine($"- {comment}");
    }
    Console.WriteLine($"Dates attended:");
    foreach (var date in student.Dates)
    {
        Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
    }
}

public class Student
{
    public string Name { get; set; }
    public List<string> Comments { get; set; }
    public List<DateTime> Dates { get; set; }

    public Student(string name, List<DateTime> dates)
    {
        this.Name = name;
        this.Comments = new List<string>();
        this.Dates = dates;
    }

}