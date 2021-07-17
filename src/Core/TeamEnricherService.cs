using Contracts;
using Models;
using System.Collections.Generic;

namespace Core
{
    public class TeamEnricherService : ITeamEnricherService
    {
        public SelectedTeam EnrichTeam(IEnumerable<Player> players)
        {
            var selectedTeam = new SelectedTeam
            {
                Batsmen = new List<Player>(),
                Bowlers = new List<Player>(),
                Keepers = new List<Player>()
            };

            foreach (var player in players)
            {
                switch (player.PlayerType)
                {
                    case Constants.Batsman:
                        selectedTeam.Batsmen.Add(player);
                        break;

                    case Constants.Bowler:
                        selectedTeam.Bowlers.Add(player);
                        break;

                    case Constants.Keeper:
                        selectedTeam.Keepers.Add(player);
                        break;
                }
            }

            return selectedTeam;
        }
    }
}
