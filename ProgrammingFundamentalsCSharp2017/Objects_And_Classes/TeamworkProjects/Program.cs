int n = int.Parse(Console.ReadLine());
Dictionary<string, Team> creatorTeamsDict = new Dictionary<string, Team>();
Dictionary<string, Team> teamsDict = new Dictionary<string, Team>();
Dictionary<string, Team> membersTeamsDict = new Dictionary<string, Team>();

for (int i = 0; i < n; i++)
{
    string[] inputTokens = Console.ReadLine().Split('-').ToArray();
    string creatorName = inputTokens[0];
    string teamName = inputTokens[1];

    if (teamsDict.ContainsKey(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }
    if (creatorTeamsDict.ContainsKey(creatorName))
    {
        Console.WriteLine($"{creatorName} cannot create another team!");
        continue;
    }
    Team team = new Team(creatorName, teamName);
    creatorTeamsDict.Add(creatorName, team);
    teamsDict.Add(teamName, team);
    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");

}

while (true)
{
    string input = Console.ReadLine();
    if (input == "end of assignment")
    {
        break;
    }
    string[] inputTokens = input.Split("->").ToArray();
    string memberName = inputTokens[0];
    string teamName = inputTokens[1];
    if (!teamsDict.ContainsKey(teamName))
    {
        Console.WriteLine($"Team {teamName} does not exist!");
        continue;
    }
    if (membersTeamsDict.ContainsKey(memberName) || creatorTeamsDict.ContainsKey(memberName))
    {
        Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
        continue;
    }
    membersTeamsDict.Add(memberName, teamsDict[teamName]);
    teamsDict[teamName].Members.Add(memberName);


}
foreach (var team in teamsDict.OrderByDescending(x => x.Value.Members.Count))
{
    Console.WriteLine(team.Key);
    Console.WriteLine($"- {team.Value.Creator}");
    foreach (var member in team.Value.Members.OrderBy(x => x))
    {
        Console.WriteLine($"-- {member}");
    }
}
Console.WriteLine("Teams to disband:");
foreach (var team in teamsDict)
{
    if (team.Value.Members.Count == 0)
    {
        Console.WriteLine(team.Key);
    }
}

public class Team
{
    public string Name { get; set; }
    public List<string> Members { get; set; }
    public string Creator { get; set; }

    public Team (string creator, string name)
    {
        this.Name = name;
        this.Members = new List<string>();
        this.Creator = creator;
    }
}