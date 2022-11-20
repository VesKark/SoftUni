internal class Program
{
    private static void Main(string[] args)
    {
        string input = string.Empty;
        Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

        while ((input = Console.ReadLine()) != "Season end")
        {
            string[] currCommand = input.Split();

            if (currCommand.Length == 5) // read player info
            {
                string playerName = currCommand[0];
                string playerPosition = currCommand[2];
                int playerSkill = int.Parse(currCommand[4]);

                if (!playerPool.ContainsKey(playerName))
                {
                    playerPool.Add(playerName, new Dictionary<string, int> { { playerPosition, playerSkill } });
                }
                else if (!playerPool[playerName].ContainsKey(playerPosition))
                {
                    playerPool[playerName].Add(playerPosition, playerSkill);
                }
                else if (playerPool[playerName][playerPosition] < playerSkill)
                {
                    playerPool[playerName][playerPosition] = playerSkill;
                }
            }
            else if (currCommand.Length == 3) // duel between players
            {
                string nameA = currCommand[0];
                string nameB = currCommand[2];

                if (playerPool.ContainsKey(nameA) && playerPool.ContainsKey(nameB))
                {
                    bool duelFinished = false;

                    foreach (var playerA in playerPool[nameA])
                    {
                        foreach (var playerB in playerPool[nameB])
                        {
                            if (playerA.Key == playerB.Key) // compare player positions
                            {
                                if (playerPool[nameA].Values.Sum() > playerPool[nameB].Values.Sum()) // compare player skills
                                {
                                    playerPool.Remove(nameB);
                                }
                                else if (playerPool[nameA].Values.Sum() < playerPool[nameB].Values.Sum())
                                {
                                    playerPool.Remove(nameA);
                                }

                                duelFinished = true;
                                break;
                            }
                        }

                        if (duelFinished)
                        {
                            break;
                        }
                    }
                }
            }
        }

        // print result:
        foreach (var player in playerPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0}: {1} skill", player.Key, player.Value.Values.Sum());

            foreach (var currPlayer in playerPool[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("- {0} <::> {1}", currPlayer.Key, currPlayer.Value);
            }
        }
    }
}