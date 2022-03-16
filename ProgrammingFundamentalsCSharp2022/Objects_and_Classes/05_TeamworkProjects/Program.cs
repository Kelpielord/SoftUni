using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_TeamworkProjects
{
    class Team
    {
        public Team(string teamLeader ,string teamName)
        {
            this.TeamLeader = teamLeader;
            this.TeamName = teamName;
            this.TeamMembers = new List<string>();
        }
        public string TeamLeader { get; set; }
        public string TeamName { get; set; }
        public List<string> TeamMembers { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            Dictionary<string, Team> teamsDict = new Dictionary<string, Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] tokens = Console.ReadLine().Split('-').ToArray();
                CreateTeam(teamsDict, tokens);
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split("->").ToArray();
                if (tokens[0] == "end of assignment")
                {
                    break;
                }
                AddMember(teamsDict, tokens);
            }

            PrintValidTeams(teamsDict);
            PrintTeamsToDisband(teamsDict);
        }

        private static void PrintTeamsToDisband(Dictionary<string, Team> teamsDict)
        {
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teamsDict.Values.Where(t => t.TeamMembers.Count == 0))
            {
                Console.WriteLine(team.TeamName);
            }
        }

        private static void PrintValidTeams(Dictionary<string, Team> teamsDict)
        {
            foreach (Team team in teamsDict.Values.Where(t => t.TeamMembers.Count > 0).OrderByDescending(t => t.TeamMembers.Count).ThenBy(t => t.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.TeamLeader}");
                foreach (string member in team.TeamMembers.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        private static void AddMember(Dictionary<string, Team> teamsDict, string[] tokens)
        {
            string teamMember = tokens[0];
            string teamName = tokens[1];
            if (!teamsDict.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                return;
            }

            foreach (var t in teamsDict.Values)
            {
                bool isAlreadyTeamMember = t.TeamMembers.FirstOrDefault(member => member == teamMember) != null;
                if (isAlreadyTeamMember || t.TeamLeader == teamMember)
                {
                    Console.WriteLine($"Member {teamMember} cannot join team {teamName}!");
                    return;
                }
            }

            teamsDict[teamName].TeamMembers.Add(teamMember);
        }


        private static void CreateTeam(Dictionary<string, Team> teamsDict, string[] tokens)
        {
            string teamLeader = tokens[0];
            string teamName = tokens[1];

            if (teamsDict.Values.FirstOrDefault(t => t.TeamLeader == teamLeader) != null)
            {
                Console.WriteLine($"{teamLeader} cannot create another team!");
                return;
            }

            if (teamsDict.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                return;
            }

            Team team = new Team(teamLeader, teamName);
            teamsDict.Add(teamName, team);
            Console.WriteLine($"Team {team.TeamName} has been created by {team.TeamLeader}!");
        }
    }
}
