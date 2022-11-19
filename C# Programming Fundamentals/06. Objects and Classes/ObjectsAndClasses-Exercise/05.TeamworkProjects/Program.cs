using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        public static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> allTeams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string userName = input[0];
                string teamName = input[1];

                if (allTeams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                    continue;
                }

                if (allTeams.Any(x => x.Creator == userName))
                {
                    Console.WriteLine("{0} cannot create another team!", userName);
                    continue;
                }

                Team thisTeam = new Team(teamName, userName);
                Console.WriteLine("Team {0} has been created by {1}!", teamName, userName);
                allTeams.Add(thisTeam);
            }

            string addMembers = string.Empty;
            string[] separator = new string[] { "->" };

            while ((addMembers = Console.ReadLine()) != "end of assignment")
            {
                string[] currentMember = addMembers.Split(separator, StringSplitOptions.None).ToArray();
                string currentUser = currentMember[0];
                string currentTeam = currentMember[1];

                // check if team exists:			
                Team searchTeam = allTeams.FirstOrDefault(x => x.TeamName == currentTeam);

                if (searchTeam == null)
                {
                    Console.WriteLine("Team {0} does not exist!", currentTeam);
                    continue;
                }

                // check if member is already in another team:
                if (allTeams.Any(x => x.TeamMembers.Contains(currentUser)) || allTeams.Any(x => x.Creator == currentUser))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", currentUser, currentTeam);
                    continue;
                }

                searchTeam.AddMember(currentUser);
            }

            List<Team> nonEmptyTeams = allTeams.Where(x => x.TeamMembers.Count > 0).ToList();
            List<Team> emptyTeams = allTeams.Where(x => x.TeamMembers.Count == 0).ToList();

            // output:
            nonEmptyTeams = nonEmptyTeams
                        .OrderByDescending(x => x.TeamMembers.Count)
                        .ThenBy(x => x.TeamName)
                        .ToList();

            emptyTeams = emptyTeams
                        .OrderBy(x => x.TeamName)
                        .ToList();

            foreach (Team team in nonEmptyTeams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in emptyTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> TeamMembers { get; set; }

        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            TeamMembers = new List<string>();
        }

        public void AddMember(string member)
        {
            TeamMembers.Add(member);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(TeamName);
            sb.AppendLine("- " + Creator);

            foreach (string member in TeamMembers)
            {
                sb.AppendLine("-- " + member);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
