using System.Globalization;

static List<Town> ReadTownsAndStudents()
{
    var towns = new List<Town>();
    var townStudents = new Dictionary<Town, List<Student>>();

    while (true)
        .
    {
        string input = Console.ReadLine();
        if (input == "End")
        {
            break;
        }

        if (input.Contains("=>"))
        {
            string[] inputTokens = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            string townName = inputTokens[0];
            int seatCount = int.Parse(inputTokens[1].Split(" ")[0]);

            Town town = new Town(townName, seatCount);
            towns.Add(town);

            townStudents.Add(town, new List<Student>());
        }
        else
        {
            Town currentTown = towns[towns.Count - 1];
            string[] inputToken = input.Split("|", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            string studentName = inputToken[0];
            string studentEmail = inputToken[1];
            DateTime regDate = DateTime.ParseExact(inputToken[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
            Student student = new Student(studentName, studentEmail, regDate);

            townStudents[currentTown].Add(student);
        }
    }

    foreach (var townStudent in townStudents)
    {
        var currentTown = townStudent.Key;
        var sortedTownStudents = townStudent.Value.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Email);
        foreach (var student in sortedTownStudents)
        {
            var lastGroup = currentTown.Groups[currentTown.Groups.Count - 1];
            if (lastGroup.Students.Count >= currentTown.SeatCounts)
            {
                Group group = new Group(currentTown);
                group.Students.Add(student);
                currentTown.Groups.Add(group);
            }
            else
            {
                lastGroup.Students.Add(student);
            }
        }
    }

    return towns;
}

List<Town> towns = ReadTownsAndStudents();
Console.WriteLine($"Created {towns.Sum(x => x.Groups.Count)} groups in {towns.Count} towns:");
foreach (Town town in towns.OrderBy(x => x.Name))
{
    foreach (var group in town.Groups)
    {
        string emails = string.Join(", ", group.Students.Select(x => x.Email));
        Console.WriteLine($"{town.Name} => {emails}");
    }
}

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }

    public Student(string name, string email, DateTime registrationDate)
    {
        this.Name = name;
        this.Email = email;
        this.RegistrationDate = registrationDate;
    }
}

public class Town
{
    public string Name { get; set; }
    public int SeatCounts { get; set; }
    public List<Group> Groups { get; set; }
    public Town(string name, int seats)
    {
        this.Name = name;
        this.SeatCounts = seats;
        this.Groups = new List<Group>();
        this.Groups.Add(new Group(this));
    }
}

public class Group
{
    public Town Town { get; set; }
    public List<Student> Students { get; set; }

    public Group(Town town)
    {
        this.Town = town;
        this.Students = new List<Student>();
    }
}